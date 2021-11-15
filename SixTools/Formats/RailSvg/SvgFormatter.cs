using Six.Core;
using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Tiles;

#pragma warning disable CA1822 // Mark members as static

namespace SixTools.Formats.RailSvg
{
    internal class SvgFormatter : IDisposable
    {
        protected readonly Writer Writer;
        protected readonly SvgDimmer D;
        private readonly RenderContext Ctx;
        protected readonly SvgWriter Svg;

        public SvgFormatter(Grammar grammar, Writer writer)
        {
            Grammar = grammar;
            Writer = writer;
            D = new SvgDimmer(10);
            Ctx = new RenderContext();
            Svg = new SvgWriter(Writer, D);
        }

        protected Grammar Grammar { get; }

        private void RenderParticle(Particle tile)
        {
            pix dy;
            pix y;
            pix rx;
            pix ry;

            switch (tile)
            {
                case Particle.BottomLeft: // '╰'
                    dy = D[-1];
                    y = D[1];
                    rx = D[0];
                    ry = D[1];
                    break;
                case Particle.TopLeft: // '╭'
                    dy = D[1];
                    y = D[-1];
                    rx = D[0];
                    ry = D[-1];
                    break;
                case Particle.BottomRight:  // '╯'
                    dy = D[0];
                    y = D[-1];
                    rx = D[1];
                    ry = D[0];
                    break;
                case Particle.TopRight:  // '╮'
                    dy = D[0];
                    y = D[1];
                    rx = D[1];
                    ry = D[0];
                    break;
                case Particle.Line:
                    Ctx.HLineMove(D[1]);
                    return;
                case Particle.None:
                default:
                    throw new InvalidOperationException();
            }

            Ctx.path.AddQ(Ctx.x, Ctx.y + dy, rx, ry, D[1], y);
            Ctx.x += D[1];
        }

        private void RenderParticleMap(Particle map)
        {
            for (var bits = (int)map; bits != 0; bits &= bits - 1)
            {
                RenderParticle((Particle)(bits & -bits));
                Ctx.x -= D[1];
            }
            Ctx.x += D[1];
        }

        private void RenderOuter(VTileType tline, bool rhs)
        {
            Particle l;
            Particle r;

            switch (tline)
            {
                case VTileType.A:
                    l = Particle.Line | Particle.BottomRight;
                    r = Particle.Line | Particle.BottomLeft;
                    break;
                case VTileType.C:
                    l = Particle.Line | Particle.TopRight;
                    r = Particle.Line | Particle.TopLeft;
                    break;
                case VTileType.D:
                    l = Particle.Line | Particle.BottomRight | Particle.TopRight;
                    r = Particle.Line | Particle.BottomLeft | Particle.TopLeft;
                    break;
                case VTileType.G:
                    l = r = Particle.Line;
                    break;
                case VTileType.H: // skipable loop joiner
                    l = Particle.Line | Particle.BottomRight;
                    r = Particle.Line | Particle.BottomLeft;
                    break;
                case VTileType.UNSET:
                case VTileType.B:
                case VTileType.E:
                case VTileType.F:
                    l = r = Particle.None;
                    break;
                default:
                    throw new NotImplementedException();
            }

            RenderParticleMap(rhs ? r : l);
        }

        private void RenderInner(VTileType tline, bool rhs)
        {
            Particle l;
            Particle r;

            switch (tline)
            {
                case VTileType.A:
                case VTileType.C:
                case VTileType.D:
                    l = r = Particle.Line;
                    break;

                case VTileType.B:
                    l = Particle.TopLeft;
                    r = Particle.TopRight;
                    break;
                case VTileType.E:
                    l = Particle.BottomLeft;
                    r = Particle.BottomRight;
                    break;
                case VTileType.F:
                    l = Particle.BottomLeft;
                    r = Particle.BottomRight;
                    break;
                case VTileType.G:
                case VTileType.H:
                    l = Particle.Line | Particle.TopLeft;
                    r = Particle.Line | Particle.TopRight;
                    break;
                case VTileType.UNSET:
                default:
                    l = r = Particle.None;
                    break;
            }

            RenderParticleMap(rhs ? r : l);
        }

        private void RenderCentered(Tile tile, pix space)
        {
            var width = tile.Width;

            Assert(space >= width);

            var lhs = (space - width) / 2;
            var rhs = space - width - lhs;

            Ctx.HLineMove(lhs);

            RenderNode(tile);

            Ctx.HLineMove(rhs);
        }

        private void Bars(pix height, pix distance, bool up)
        {
            Ctx.VLine(height, up);
            Ctx.x += distance;
            Ctx.VLine(height, !up);
        }

        private void RenderTextbox(string klass, string text, pix width, pix round)
        {
            Svg.Textbox(klass, text, Ctx.x, Ctx.y, width, D[2], round);

            Ctx.x += width;
        }

        private void RenderToken(TokenTile token)
        {
            RenderTextbox("token", token.Text, token.Width, 20 % D[1]);
        }

        private void RenderReference(ReferenceTile reference)
        {
            using (Writer.TagIndent("a", "", $"href='{Ctx.RefBase}#{Esc.HtmlEntity(reference.Text)}'"))
            {
                RenderTextbox("reference", reference.Text, reference.Width, 20 % D[1]);
            }
        }

        private void RenderSingleCharacter(Codepoint utf32, bool withRererence)
        {
            var text = Esc.ControlName(utf32) ?? utf32.ToString();

            text = Esc.HtmlEntity(text);

            if (withRererence)
            {
                var reference = $"https://www.compart.com/en/unicode/U+{(int)utf32:X4}";
                using (Writer.TagStraight("a", "", $"href='{reference}' target='_blank'"))
                {
                    Writer.Write($"<tspan class='single'>{text}</tspan>");
                }
            }
            else
            {
                Writer.Write($"<tspan class='single'>{text}</tspan>");
            }
        }

        private void RenderAnnotated(AnnotatedTile annotated)
        {
            var offset = 5;

            var y = Ctx.y + annotated.Descender - offset; /* off-grid */
            Svg.Text("annotation", annotated.Text, Ctx.x, y, annotated.Width);

            RenderCentered(annotated.Node, annotated.Width);
        }

        private void RenderRange(RangeTile range)
        {
            var x = Ctx.x;
            var y = Ctx.y;

            Svg.Literal("literal", x, y, range.Width);
            using (Writer.TagStraight("text", "range", $"x='{x + (range.Width / 2)}' y='{y + (40 % D[1])}' text-anchor='middle'"))
            {
                RenderSingleCharacter(range.Start, true);
                Writer.Write($"<tspan class='ellipsis'>⋯</tspan>");
                RenderSingleCharacter(range.Stop, true);
            }
            Writer.WriteLine();

            Ctx.x += range.Width;
        }

        private void RenderLiteral(LiteralTile literal)
        {
            var x = Ctx.x;
            var y = Ctx.y;

            Svg.Literal("literal", x, y, literal.Width);

            var text = literal.Text;
            var withReference = !text.All(c => char.IsLetterOrDigit(c));

            var baseOffset = 40 % D[1];

            using (Writer.TagStraight("text", "", $"x='{x + (literal.Width / 2)}' y='{y + baseOffset}' text-anchor='middle'"))
            {
                foreach (var cp in text.Codepoints())
                {
                    RenderSingleCharacter(cp, withReference);
                }
            }
            Writer.WriteLine();

            Ctx.x += literal.Width;
        }

        private void RenderVTile(VTile node)
        {
            Assert(node.Count >= 2);
            Assert(node.Offset <= 1); /* currently only implemented for one node above the line */

            var o = Ctx.y;

            if (node.Offset == 1)
            {
                Ctx.y -= node.Ascender - D[1];
            }

            var x = Ctx.x;
            var y = Ctx.y;

            for (var j = 0; j < node.Count; j++)
            {
                Ctx.x = x;
                var item = node[j];

                RenderOuter(item.B, false);
                RenderInner(item.B, false);
                RenderCentered(item.A, node.Width - D[4]);
                RenderInner(item.B, true);
                RenderOuter(item.B, true);

                Ctx.y += D[1];
                if (j + 1 < node.Count)
                {
                    Ctx.y += item.A.Descender + node[j + 1].A.Ascender;
                }
            }

            /* bars above the line */
            if (node.Offset > 0)
            {
                var h = D[0];

                for (var j = 0; j < node.Offset; j++)
                {
                    if (j + 1 < node.Count)
                    {
                        h += node[j].A.Descender + node[j + 1].A.Ascender + D[1];
                    }
                }

                Ctx.x = x + D[1];
                Ctx.y = y + D[1];

                h -= D[2]; /* for the tline corner pieces */
                Bars(h, node.Width - D[2], true);
            }

            /* bars below the line */
            if (node.Count > node.Offset + 1)
            {
                var h = D[0];

                for (var j = node.Offset; j < node.Count; j++)
                {
                    if (j + 1 < node.Count)
                    {
                        h += node[j].A.Descender + node[j + 1].A.Ascender + D[1];
                    }
                }

                Ctx.x = x + D[1];
                Ctx.y = o + D[1];

                h -= D[2]; /* for the tline corner pieces */
                Bars(h, node.Width - D[2], false);
            }

            Ctx.x = x + node.Width;
            Ctx.y = o;
        }

        private void RenderHTile(HTile hNode)
        {
            var more = false;
            foreach (var node in hNode.Nodes)
            {
                if (more)
                {
                    Ctx.HLineMove(D[2]);
                }
                more = true;
                RenderNode(node);
            }
        }

        private void RenderLeftToRightArrow(ToRightArrowTile aNode)
        {
            var w = aNode.Width;

            Ctx.HLineMove(w);
            Svg.Arrow(Ctx.x - (w / 2), Ctx.y, false);
        }

        private void RenderRightToLeftArrow(ToLeftArrowTile aNode)
        {
            var w = aNode.Width;

            Ctx.HLineMove(w);
            Svg.Arrow(Ctx.x - (w / 2), Ctx.y, true);
        }

        private void RenderProse(ProseTile prose)
        {
            Svg.Text("prose", prose.Text, Ctx.x, Ctx.y, prose.Width);
            Ctx.x += prose.Width;
        }

        private void RenderComment(CommentTile comment)
        {
            Svg.Text("comment", comment.Text, Ctx.x, Ctx.y, comment.Width);
            Ctx.x += comment.Width;
        }

        private void RenderNode(Tile node)
        {
            switch (node)
            {
                case VTile vNode:
                    RenderVTile(vNode);
                    break;
                case HTile hNode:
                    RenderHTile(hNode);
                    break;
                case TokenTile tokenNode:
                    RenderToken(tokenNode);
                    break;
                case ReferenceTile referenceNode:
                    RenderReference(referenceNode);
                    break;
                case ToRightArrowTile toRightArrowNode:
                    RenderLeftToRightArrow(toRightArrowNode);
                    break;
                case ToLeftArrowTile toLeftArrowNode:
                    RenderRightToLeftArrow(toLeftArrowNode);
                    break;
                case LiteralTile literalNode:
                    RenderLiteral(literalNode);
                    break;
                case RangeTile range:
                    RenderRange(range);
                    break;
                case AnnotatedTile annotated:
                    RenderAnnotated(annotated);
                    break;
                case ProseTile prose:
                    RenderProse(prose);
                    break;
                case CommentTile comment:
                    RenderComment(comment);
                    break;
                case NotTile not:
                    RenderNot(not);
                    break;
                case AnyTile any:
                    RenderAny(any);
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        private void RenderNot(NotTile not)
        {
            // "⌐"

            var x0 = Ctx.x;
            var x1 = Ctx.x + D[2];
            var y = Ctx.y;

            Ctx.x += D[2];
            RenderNode(not.Inner);
            Svg.Rect("frame", x1, y - not.Inner.Ascender, not.Inner.Width, not.Inner.Height, D[0]);
            Svg.Textbox("function", "¬", x0, y, D[2], D[2], D[0]);
        }

        private void RenderAny(AnyTile any)
        {
            var x = Ctx.x;
            var y = Ctx.y;

            Svg.Rect("frame", x, y - any.Ascender, any.Width, any.Height, D[0]);
            Svg.Textbox("function", "●", x, y, any.Width, any.Height, D[0]);
        }

        private void RenderLeftStation(pix x, pix y)
        {
            var gap = 40 % D[1];
            var h = 70 % D[2];

            Writer.WriteLine($"<path class='station' d='M{x},{y - (h / 2)} v{h} m{gap},0 v{-h} m{0},{h / 2} h{D[1] - gap}'/>");
        }

        private void RenderRightStation(pix x, pix y)
        {
            var gap = 40 % D[1];
            var h = 70 % D[2];

            Writer.WriteLine($"<path class='station' d='M{x},{y} h{D[1] - gap} m{0},{-(h / 2)} v{h} m{gap},0 v{-h}'/>");
        }

        protected void ProvideStyle()
        {
            using (Writer.TagIndent("style"))
            {
                EmbeddedResources.GetCss(Writer, typeof(SvgFormatter).Namespace + ".SvgStyle");
            }
        }

        protected void RenderRule(Tile node, string refBase)
        {
            Ctx.Reset(refBase);

            Ctx.x = D[0];
            Ctx.y = node.Ascender;
            RenderLeftStation(Ctx.x, Ctx.y);

            Ctx.x = D[1];
            Ctx.HLineMove(D[2]);

            Ctx.x += node.Width;

            Ctx.HLineMove(D[2]);

            RenderRightStation(Ctx.x, Ctx.y);

            Ctx.x = D[3];
            Ctx.y = node.Ascender;
            RenderNode(node);

            Ctx.RenderPaths(Writer);
        }

        public void Dispose()
        {
            D.Dispose();
        }

        [Flags]
        private enum Particle
        {
            None = 0,

            BottomLeft = 1 << 0, /* `- bottom left */
            TopLeft = 1 << 1, /* .- top left */
            BottomRight = 1 << 2, /* -' bottom right */
            TopRight = 1 << 3, /* -. top right */

            Line = 1 << 4, /* horizontal line */
        }
    }
}
