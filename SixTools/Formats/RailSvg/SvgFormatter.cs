using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Tiles;

namespace SixTools.Formats.RailSvg
{
    internal class SvgFormatter
    {
        protected readonly Grammar grammar;
        protected readonly Writer writer;
        protected readonly Dimmer dim = new SvgDimmer();
        private readonly RenderContext Ctx;
        private readonly SvgWriter Svg;

        public SvgFormatter(Grammar grammar, Writer writer)
        {
            this.grammar = grammar;
            this.writer = writer;
            Ctx = new RenderContext();
            Svg = new SvgWriter(writer);
        }

        private void RenderParticle(Particle tile)
        {
            int dy;
            int y;
            int rx;
            int ry;

            switch (tile)
            {
                case Particle.BottomLeft: // '╰'
                    dy = -10;
                    y = 10;
                    rx = 0;
                    ry = 10;
                    break;
                case Particle.TopLeft: // '╭'
                    dy = 10;
                    y = -10;
                    rx = 0;
                    ry = -10;
                    break;
                case Particle.BottomRight:  // '╯'
                    dy = 0;
                    y = -10;
                    rx = 10;
                    ry = 0;
                    break;
                case Particle.TopRight:  // '╮'
                    dy = 0;
                    y = 10;
                    rx = 10;
                    ry = 0;
                    break;
                case Particle.Line:
                    Ctx.HLineMove(U.Scale(1));
                    return;
                case Particle.None:
                default:
                    throw new InvalidOperationException();
            }

            Ctx.path.AddQ(Ctx.x, Ctx.y + dy, rx, ry, 10, y);
            Ctx.x += 10;
        }

        private void RenderParticleMap(Particle map)
        {
            for (var bits = (int)map; bits != 0; bits &= bits - 1)
            {
                RenderParticle((Particle)(bits & -bits));
                Ctx.x -= 10;
            }
            Ctx.x += 10;
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

        private void RenderCentered(Tile tile, int space)
        {
            var width = U.Scale(tile.Width);

            Assert(space >= width);

            var lhs = (space - width) / 2;
            var rhs = space - width - lhs;

            Ctx.HLineMove(lhs);

            RenderNode(tile);

            Ctx.HLineMove(rhs);
        }

        private void Bars(int height, int distance)
        {
            Ctx.VLine(height);
            Ctx.x += distance;
            Ctx.VLine(height);
        }

        private void RenderTextbox(string text, int width, int round, string klass)
        {
            Svg.Textbox(text, Ctx.x, Ctx.y, U.Scale(width), U.Unit, round, klass);

            Ctx.x += U.Scale(width);
        }

        private void RenderToken(TokenTile token)
        {
            RenderTextbox(token.Text, token.Width, 0, "token");
        }

        private void RenderReference(ReferenceTile reference)
        {
            using (writer.TagIndent("a", "", $"href='{Ctx.RefBase}#{reference.Text}'")) // TODO: escaping?
            {
                RenderTextbox(reference.Text, reference.Width, 0, "reference");
            }
        }

        private void RenderSingleCharacter(int utf32)
        {
            var text = Esc.SvgControl(utf32);

            text = text == null
                ? char.ConvertFromUtf32(utf32)
                : $"{text}";

            var reference = $"https://www.compart.com/en/unicode/U+{utf32:X4}";
            using (writer.TagIndent("a", "charref", $"href='{reference}' target='_blank'"))
            {
                writer.WriteLine($"<tspan class='single'>{text}</tspan>");
            }
        }

        private void RenderRange(RangeTile range)
        {
            var x = Ctx.x;
            var y = Ctx.y;

            Svg.Diamond(x, y, U.Scale(range.Width), "diamond");
            using (writer.TagIndent("text", "", $"x='{x + (U.Scale(range.Width) / 2)}' y='{y + 4}' text-anchor='middle'"))
            {
                RenderSingleCharacter(range.Start);
                writer.WriteLine($"<tspan>⋯</tspan>");
                RenderSingleCharacter(range.Stop);
            }

            Ctx.x += U.Scale(range.Width);
        }

        private void RenderAnnotated(AnnotatedTile annotated)
        {
            var offset = 5;

            Ctx.y += U.Scale(annotated.Descender);
            Ctx.y -= offset; /* off-grid */
            Svg.Text(Ctx.x, Ctx.y, U.Scale(annotated.Width), annotated.Text, "annotation");
            Ctx.y += offset;
            Ctx.y -= U.Scale(annotated.Descender);
            RenderCentered(annotated.Node, U.Scale(annotated.Width));
        }

        private void RenderLiteral(LiteralTile literal)
        {
            var x = Ctx.x;
            var y = Ctx.y;

            Svg.Diamond(x, y, U.Scale(literal.Width), "literal");

            var text = literal.Text;

            using (writer.TagIndent("text", "", $"x='{x + (U.Scale(literal.Width) / 2)}' y='{y + 4}' text-anchor='middle'"))
            {
                var i = 0;
                while (i < text.Length)
                {
                    int utf32;
                    if (char.IsSurrogatePair(text, i))
                    {
                        utf32 = char.ConvertToUtf32(text, i);
                        Assert(char.ConvertFromUtf32(utf32).Length == 2);
                        i += 2;
                    }
                    else if (char.IsSurrogate(text, i))
                    {
                        utf32 = '�'; // replacement character
                    }
                    else
                    {
                        utf32 = text[i];
                        i += 1;
                    }

                    RenderSingleCharacter(utf32);
                }
            }

            Ctx.x += U.Scale(literal.Width);
        }

        private void RenderVTile(VTile node)
        {
            Assert(node.Count >= 2);
            Assert(node.Offset <= 1); /* currently only implemented for one node above the line */

            var o = Ctx.y;

            if (node.Offset == 1)
            {
                Ctx.y -= U.Scale(node.Ascender - 1);
            }

            var x = Ctx.x;
            var y = Ctx.y;

            for (var j = 0; j < node.Count; j++)
            {
                Ctx.x = x;
                var item = node[j];

                RenderOuter(item.B, false);
                RenderInner(item.B, false);
                RenderCentered(item.A, U.Scale(node.Width - 4));
                RenderInner(item.B, true);
                RenderOuter(item.B, true);

                Ctx.y += 10;
                if (j + 1 < node.Count)
                {
                    Ctx.y += (item.A.Descender + node[j + 1].A.Ascender) * 10;
                }
            }

            /* bars above the line */
            if (node.Offset > 0)
            {
                var h = 0;

                for (var j = 0; j < node.Offset; j++)
                {
                    if (j + 1 < node.Count)
                    {
                        h += (node[j].A.Descender + node[j + 1].A.Ascender + 1) * 10;
                    }
                }

                Ctx.x = x + 10;
                Ctx.y = y + 10;

                h -= 20; /* for the tline corner pieces */
                Bars(h, (node.Width * 10) - 20);
            }

            /* bars below the line */
            if (node.Count > node.Offset + 1)
            {
                var h = 0;

                for (var j = node.Offset; j < node.Count; j++)
                {
                    if (j + 1 < node.Count)
                    {
                        h += (node[j].A.Descender + node[j + 1].A.Ascender + 1) * 10;
                    }
                }

                Ctx.x = x + 10;
                Ctx.y = o + 10;

                h -= 20; /* for the tline corner pieces */
                Bars(h, (node.Width * 10) - 20);
            }

            Ctx.x = x + (node.Width * 10);
            Ctx.y = o;
        }

        private void RenderHTile(HTile hNode)
        {
            var more = false;
            foreach (var node in hNode.Nodes)
            {
                if (more)
                {
                    Ctx.HLineMove(U.Unit);
                }
                more = true;
                RenderNode(node);
            }
        }

        private void RenderLeftToRightArrow(ToRightArrowTile aNode)
        {
            var w = U.Scale(aNode.Width);

            Ctx.HLineMove(w);
            Svg.Arrow(Ctx.x - (w / 2), Ctx.y, false);
        }

        private void RenderRightToLeftArrow(ToLeftArrowTile aNode)
        {
            var w = U.Scale(aNode.Width);

            Ctx.HLineMove(w);
            Svg.Arrow(Ctx.x - (w / 2), Ctx.y, true);
        }

        private void RenderProse(ProseTile prose)
        {
            Svg.Text(Ctx.x, Ctx.y, U.Scale(prose.Width), prose.Text, "prose");
            Ctx.x += U.Scale(prose.Width);
        }

        private void RenderComment(CommentTile comment)
        {
            Svg.Text(Ctx.x, Ctx.y, U.Scale(comment.Width), comment.Text, "comment");
            Ctx.x += U.Scale(comment.Width);
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
                default:
                    throw new InvalidOperationException();
            }
        }

        private void RenderLeftStation(int x, int y)
        {
            var gap = 4;
            var h = 14;

            writer.WriteLine($"<path class='station' d='M{x + 1},{y - (h / 2)} v{h} m{gap},0 v{-h} m{0},{h / 2} h{5}'/>");
        }

        private void RenderRightStation(int x, int y)
        {
            var gap = 4;
            var h = 14;

            writer.WriteLine($"<path class='station' d='M{x},{y} h{5} m{0},{-(h / 2)} v{h} m{gap},0 v{-h}'/>");
        }

        protected void ProvideStyle()
        {
            using (writer.TagIndent("style"))
            {
                EmbeddedResources.GetCss(writer, typeof(SvgFormatter).Namespace + ".SvgStyle");
            }
        }

        protected void RenderRule(Tile node, string refBase, int down = 0)
        {
            Ctx.Reset(refBase);

            Ctx.x = 0;
            Ctx.y = U.Scale(node.Ascender) + down;
            RenderLeftStation(Ctx.x, Ctx.y);

            Ctx.x = U.Scale(1);
            Ctx.HLineMove(U.Scale(2));

            Ctx.x += U.Scale(node.Width);

            Ctx.HLineMove(U.Scale(2));

            RenderRightStation(Ctx.x, Ctx.y);

            Ctx.x = U.Scale(3);
            Ctx.y = U.Scale(node.Ascender) + down;
            RenderNode(node);

            /*
             * Consolidate adjacent nodes of the same type.
             */
            Ctx.path.Consolidate();

            var p = Ctx.path.ExtractOne();
            while (p != null)
            {
                writer.Write($"<path class='rail' d='M{p.x0} {p.y0}");
                do
                {
                    switch (p)
                    {
                        case PathH h:
                            writer.Write($" h{h.n}");
                            break;
                        case PathV v:
                            writer.Write($" v{v.n}");
                            break;
                        case PathQ q:
                            writer.Write($" q{q.rx} {q.ry} {q.mx} {q.my}");
                            break;
                        default:
                            throw new InvalidOperationException();
                    }

                    p = Ctx.path.ExtractNext(p.x1, p.y1);

                }
                while (p != null);

                writer.WriteLine("'/>");

                p = Ctx.path.ExtractOne();
            }
        }
        protected static class U
        {
            public const int Scaler = 10;
            public const int Unit = 20;

            public static int Scale(int u)
            {
                return u * Scaler;
            }
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
