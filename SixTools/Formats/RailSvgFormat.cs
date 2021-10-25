using SixTools.Ast;
using SixTools.Rails;
using SixTools.Tiles;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable CA1712 // Do not prefix enum values with type name
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0066 // Convert switch statement to expression
#pragma warning disable IDE1006 // Naming Styles

namespace SixTools.Formats
{
    public class RailSvgFormat : IFormat
    {
        public readonly bool Debug = true;
        public string PreferedExtension => ".svg";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
        }

        private class RenderContext
        {
            public int x;
            public int y;
            public readonly SvgPath path = new();
            public string RefBase = string.Empty;

            public void Reset(string refBase = "")
            {
                x = 0;
                y = 0;
                path.Clear();
                RefBase = refBase;
            }

            public void AddH(int n)
            {
                path.AddH(x, y, n);
            }

            public void AddV(int n)
            {
                path.AddV(x, y, n);
            }

            public int Scale => 10;

            public int Zehn => 10;
            public int Zwanzig => 20;
        }

        private static class U
        {
            public const int Scaler = 10;
            public const int Unit = 20;

            public static int Scale(int u)
            {
                return u * Scaler;
            }
        }

        [Flags]
        private enum TileX
        {
            TILE_NONE = 0,

            TILE_BL = 1 << 0, /* `- bottom left */
            TILE_TL = 1 << 1, /* .- top left */
            TILE_BR = 1 << 2, /* -' bottom right */
            TILE_TR = 1 << 3, /* -. top right */

            TILE_LINE = 1 << 4, /* horizontal line */

            TILE_BL_N1 = 1 << 5,
            TILE_BR_N1 = 1 << 6,
            TILE_TR_N1 = 1 << 7
        }

        private class Formatter
        {
            private readonly Grammar grammar;
            private readonly Writer writer;
            private readonly Dimmer dim = new SvgDimmer();
            private readonly RenderContext ctx = new();
            private readonly SvgWriter Svg;

            public Formatter(Grammar grammar, Writer writer)
            {
                this.grammar = grammar;
                this.writer = writer;
                Svg = new SvgWriter(this);
            }

            public void Format()
            {
                List<(string, Tile)> tiles = new();

                foreach (var rule in grammar.Rules)
                {
                    var node = RailMaker.Make(rule.Term);
                    var tile = TileMaker.Make(node, dim);

                    tiles.Add((rule.Name.Text, tile));
                }

                Render(tiles);
            }

            private void RenderTile(TileX tile)
            {
                int dy;

                switch (tile)
                {
                    case TileX.TILE_BL_N1:
                        tile = TileX.TILE_BL;
                        dy = -10;
                        break;
                    case TileX.TILE_BR_N1:
                        tile = TileX.TILE_BR;
                        dy = -10;
                        break;
                    case TileX.TILE_TR_N1:
                        tile = TileX.TILE_TR;
                        dy = -10;
                        break;
                    case TileX.TILE_TL:
                        dy = 10;
                        break;
                    case TileX.TILE_BR:
                    case TileX.TILE_TR:
                    case TileX.TILE_LINE:
                        dy = 0;
                        break;
                    case TileX.TILE_NONE:
                    case TileX.TILE_BL:
                    default:
                        throw new InvalidOperationException();
                }

                int y;
                int rx;
                int ry;

                switch (tile)
                {
                    case TileX.TILE_BL:
                        y = 10;
                        rx = 0;
                        ry = 10;
                        break;
                    case TileX.TILE_TL:
                        y = -10;
                        rx = 0;
                        ry = -10;
                        break;
                    case TileX.TILE_BR:
                        y = -10;
                        rx = 10;
                        ry = 0;
                        break;
                    case TileX.TILE_TR:
                        y = 10;
                        rx = 10;
                        ry = 0;
                        break;

                    case TileX.TILE_LINE:
                        ctx.path.AddH(ctx.x, ctx.y + dy, 10);
                        ctx.x += 10;
                        return;

                    case TileX.TILE_NONE:
                    case TileX.TILE_BL_N1:
                    case TileX.TILE_BR_N1:
                    case TileX.TILE_TR_N1:
                    default:
                        throw new InvalidOperationException();
                }

                ctx.path.AddQ(ctx.x, ctx.y + dy, rx, ry, 10, y);
                ctx.x += 10;
            }

            private void RenderTileBm(TileX u)
            {
                if (u == TileX.TILE_NONE)
                {
                    /* nothing to draw */
                    ctx.x += 10;
                    return;
                }

                for (var v = (uint)u; v != 0; v &= v - 1)
                {
                    RenderTile((TileX)(v & -v));

                    if ((v & (v - 1)) != 0)
                    {
                        ctx.x -= 10;
                    }
                }
            }

            private void RenderOuter(VTileType tline, int rhs)
            {
                var u = new[] { TileX.TILE_NONE, TileX.TILE_NONE };

                switch (tline)
                {
                    case VTileType.TLINE_A:
                    case VTileType.TLINE_a:
                        u[0] = TileX.TILE_LINE | TileX.TILE_BR;
                        u[1] = TileX.TILE_LINE | TileX.TILE_BL_N1;
                        break;
                    case VTileType.TLINE_C:
                    case VTileType.TLINE_c:
                        u[0] = TileX.TILE_LINE | TileX.TILE_TR;
                        u[1] = TileX.TILE_LINE | TileX.TILE_TL;
                        break;
                    case VTileType.TLINE_D:
                    case VTileType.TLINE_d:
                        u[0] = TileX.TILE_LINE | TileX.TILE_BR | TileX.TILE_TR;
                        u[1] = TileX.TILE_LINE | TileX.TILE_BL_N1 | TileX.TILE_TL;
                        break;
                    case VTileType.TLINE_H:
                    case VTileType.TLINE_h:
                        u[0] = TileX.TILE_LINE;
                        u[1] = TileX.TILE_LINE;
                        break;
                    case VTileType.UNSET:
                    case VTileType.TLINE_B:
                    case VTileType.TLINE_E:
                    case VTileType.TLINE_F:
                    case VTileType.TLINE_G:
                    case VTileType.TLINE_g:
                        u[0] = TileX.TILE_NONE;
                        u[1] = TileX.TILE_NONE;
                        break;
                    default:
                        throw new NotImplementedException();
                }

                RenderTileBm(u[rhs]);
            }

            private void RenderInner(VTileType tline, int rhs)
            {
                TileX x;

                switch (tline)
                {
                    case VTileType.TLINE_A:
                    case VTileType.TLINE_a:
                    case VTileType.TLINE_C:
                    case VTileType.TLINE_c:
                    case VTileType.TLINE_D:
                    case VTileType.TLINE_d:
                        x = TileX.TILE_LINE;
                        break;

                    case VTileType.TLINE_B:
                        x = (rhs == 0) ? TileX.TILE_TL : TileX.TILE_TR;
                        break;
                    case VTileType.TLINE_E:
                        x = (rhs == 0) ? TileX.TILE_BL_N1 : TileX.TILE_BR;
                        break;
                    case VTileType.TLINE_G:
                    case VTileType.TLINE_g:
                        x = (rhs == 0) ? TileX.TILE_BL_N1 : TileX.TILE_BR;
                        break;
                    case VTileType.TLINE_H:
                    case VTileType.TLINE_h:
                        x = (rhs == 0) ? TileX.TILE_LINE | TileX.TILE_TL : TileX.TILE_LINE | TileX.TILE_TR;
                        break;

                    case VTileType.TLINE_F:
                    case VTileType.UNSET:
                    default:
                        x = TileX.TILE_NONE;
                        break;
                }

                RenderTileBm(x);
            }

            private void Justify(Tile n, int space)
            {
                if (space < n.Width * 10)
                {
                    Assert(space >= n.Width * 10);
                }

                var lhs = 0;
                var rhs = 0;

                Center(ref lhs, ref rhs, space, n.Width);

                if (n is not EllipsisTile)
                {
                    ctx.path.AddH(ctx.x, ctx.y, lhs);
                }

                ctx.x += lhs;

                RenderNode(n);

                if (n is not EllipsisTile)
                {
                    ctx.path.AddH(ctx.x, ctx.y, rhs);
                }

                ctx.x += rhs;
            }

            private void Center(ref int lhs, ref int rhs, int space, int w)
            {
                Assert(space >= (w * 10));

                lhs = (space - (w * 10)) / 2;
                rhs = space - (w * 10) - lhs;
            }

            private void Bars(int n, int w)
            {
                ctx.path.AddV(ctx.x, ctx.y, n);
                ctx.x += w;
                ctx.path.AddV(ctx.x, ctx.y, n);
            }
            private string Klass(string klass)
            {
                if (!string.IsNullOrWhiteSpace(klass))
                {
                    return $" class='{klass}'";
                }
                return string.Empty;
            }

            private void AddKlass(string klass)
            {
                writer.Write(Klass(klass));
            }

            private class SvgWriter
            {
                public SvgWriter(Formatter formatter)
                {
                    this.formatter = formatter;
                }

                private readonly Formatter formatter;
                private Writer writer => formatter.writer;

                public void Text(int x, int y, int w, string text, string klass)
                {
                    // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/text

                    writer.Write($"<text x='{x + (w / 2)}' y='{y}' text-anchor='middle'{formatter.Klass(klass)}");
                    writer.WriteLine($">{text}</text>");
                }

                public void Rect(int x, int y, int w, int r, string klass)
                {
                    // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/rect

                    writer.Write($"<rect x='{x}' y='{y}' height='{U.Unit}' width='{w}' rx='{r}' ry='{r}'{formatter.Klass(klass)}");
                    writer.WriteLine("/>");
                }

                public void Diam(int x, int y, int w, string klass)
                {
                    writer.Write($"<path d='M{x},{y + 10} l{5},{-10} h{w - 10} l{5},{10} l{-5},{10} h{-(w - 10)} z'{formatter.Klass(klass)}/>");
                }

                public void Textbox(string text, int x, int y, int w, int r, string klass)
                {
                    Rect(x, y - 10, w, r, klass);
                    Text(x, y + 4, w, text, klass);
                }

                public void DiamondBox(string text, int x, int y, int w, string klass)
                {
                    Diam(x, y - 10, w, klass);
                    Text(x, y + 4, w, text, klass);
                }

                public void Diamond(int x, int y, int w, string klass)
                {
                    Diam(x, y - 10, w, klass);
                }

                public void Arrow(int x, int y, bool rtl)
                {
                    /* XXX: should be markers, but aren't for RFC 7996 */
                    // SEE: https://datatracker.ietf.org/doc/html/rfc7996
                    /* 2 for optical correction */

                    var h = 6;

                    writer.WriteLine($"<path d='M{x + (rtl ? -2 : 2)} {y} l{(rtl ? 4 : -4)} {h / 2} v{-h} z' class='arrow'/>");
                }

                public void Ellipsis(int x, int y, int h)
                {
                    writer.Write($"<line x1='{x}' y1='{y}' x2='{x}' y2='{y + h}' class='ellipsis'/>");
                }
            }

            private void RenderTextbox(string text, int width, int round, string klass)
            {
                Svg.Textbox(text, ctx.x, ctx.y, U.Scale(width), round, klass);

                ctx.x += U.Scale(width);
            }

            private void RenderToken(TokenTile token)
            {
                RenderTextbox(token.Text, token.Width, 0, "token");
            }

            private void RenderReference(ReferenceTile reference)
            {
                writer.WriteLine($"<a href='{ctx.RefBase}#{reference.Text}'>"); // TODO: escaping?
                using (writer.Indent())
                {
                    RenderTextbox(reference.Text, reference.Width, 0, "reference");
                }
                writer.WriteLine("</a>");
            }

            private void RenderDiamond(string text, int width, string klass)
            {
                Svg.DiamondBox(text, ctx.x, ctx.y, U.Scale(width), klass);

                ctx.x += U.Scale(width);
            }

            private void RenderCharacter(int utf32, int width)
            {
                var text = char.ConvertFromUtf32(utf32);
                var reference = $"https://www.compart.com/unicode/U+{utf32:X4}";
                writer.WriteLine($"<a href='{reference}' target='_blank'>");
                using (writer.Indent())
                {
                    RenderDiamond(text, width, "literal");
                }
                writer.WriteLine("</a>");
            }

            private void RenderRange(RangeTile range)
            {
                var x = ctx.x;
                var y = ctx.y; ;

                Svg.Diamond(x, y, U.Scale(range.Width), "diamond");
                writer.Write($"<text x='{x + (U.Scale(range.Width) / 2)}' y='{y + 4}' text-anchor='middle'>");
                writer.Write($"<tspan>[</tspan>");
                anchored(range.Start);
                writer.Write($"<tspan>-</tspan>");
                anchored(range.Stop);
                writer.Write($"<tspan>]</tspan>");
                writer.WriteLine("</text>");
                ctx.x += U.Scale(range.Width);

                void anchored(int utf32)
                {
                    var text = char.ConvertFromUtf32(utf32);
                    var reference = $"https://www.compart.com/unicode/U+{utf32:X4}";
                    writer.Write($"<a href='{reference}' target='_blank'><tspan>{text}</tspan></a>");
                }
            }

            private void RenderLiteral(LiteralTile literal)
            {
                var text = literal.Text;

                Assert(text.Length >= 1);

                if (text.Length == 2 && char.IsSurrogatePair(text, 0))
                {
                    RenderCharacter(char.ConvertToUtf32(text, 0), literal.Width);
                }
                else if (text.Length == 1)
                {
                    RenderCharacter(text[0], literal.Width);
                }
                else
                {
                    RenderDiamond(text, literal.Width, "literal");
                }
            }

            private void RenderVTile(VTile node)
            {
                Assert(node.Count >= 2);
                Assert(node.Offset <= 1); /* currently only implemented for one node above the line */

                var o = ctx.y;

                if (node.Offset == 1)
                {
                    ctx.y -= U.Scale(node.Ascender - 1);
                }

                var x = ctx.x;
                var y = ctx.y;

                for (var j = 0; j < node.Count; j++)
                {
                    ctx.x = x;
                    var item = node[j];

                    RenderOuter(item.B, 0);
                    RenderInner(item.B, 0);
                    Justify(item.A, U.Scale(node.Width - 4));
                    RenderInner(item.B, 1);
                    RenderOuter(item.B, 1);

                    ctx.y += 10;
                    if (j + 1 < node.Count)
                    {
                        ctx.y += (item.A.Descender + node[j + 1].A.Ascender) * 10;
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

                    ctx.x = x + 10;
                    ctx.y = y + 10;

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

                    ctx.x = x + 10;
                    ctx.y = o + 10;

                    h -= 20; /* for the tline corner pieces */
                    Bars(h, (node.Width * 10) - 20);
                }

                ctx.x = x + (node.Width * 10);
                ctx.y = o;
            }

            private void RenderHTile(HTile hNode)
            {
                var more = false;
                foreach (var node in hNode.Nodes)
                {
                    if (more)
                    {
                        ctx.path.AddH(ctx.x, ctx.y, ctx.Zwanzig);
                        ctx.x += ctx.Zwanzig;
                    }
                    more = true;
                    RenderNode(node);
                }
            }

            private void RenderLeftToRightArrow(ToRightArrowTile aNode)
            {
                ctx.path.AddH(ctx.x, ctx.y, aNode.Width * 10);
                Svg.Arrow(ctx.x + (aNode.Width * 5), ctx.y, false);
                ctx.x += aNode.Width * 10;
            }

            private void RenderRightToLeftArrow(ToLeftArrowTile aNode)
            {
                var w = U.Scale(aNode.Width);

                ctx.path.AddH(ctx.x, ctx.y, w);
                Svg.Arrow(ctx.x + (w / 2), ctx.y, true);
                ctx.x += w;
            }

            private void RenderEllipsis(EllipsisTile ellipsis)
            {
                Svg.Ellipsis(ctx.x + (U.Scale(ellipsis.Width) / 2), ctx.y - (U.Scale(ellipsis.Height) / 2), U.Scale(ellipsis.Height));

                ctx.x += U.Scale(ellipsis.Width);
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
                    case EllipsisTile ellipsisNode:
                        RenderEllipsis(ellipsisNode);
                        break;
                    case AnnotationTile:
                        break;
                    default:
                        break;
                }
#if false
	            switch (n->type)
	            {
		            case TNODE_PROSE:
			            svg_prose(ctx, n->text, n->w * 10);
			            break;

		            case TNODE_COMMENT: {
			            unsigned offset = 5;

			            ctx->y += n->d * 10;

			            /* TODO: - 5 again for loops with a backwards skip (because they're short) */
			            if (n->commented->type == TNODE_VLIST &&
				            n->commented->vlist.o == 0 &&
				            n->commented->vlist.n == 2 &&
				            ((n->commented->vlist.a[1]->type == TNODE_VLIST && n->commented->vlist.a[1]->vlist.n == 0) || n->commented->vlist.a[1]->type == TNODE_RTL_ARROW || n->commented->vlist.a[1]->type == TNODE_LTR_ARROW))
			            {
				            offset += 10;
			            }

			            ctx->y -= offset; /* off-grid */
			            svg_string(ctx, n->w * 10, n->text, "comment");
			            ctx->y += offset;
			            ctx->y -= n->d * 10;
			            justify(ctx, n->commented, n->w * 10, base);
			            break;
		            }
	            }
#endif
            }

            private void RenderStation(int x, int y)
            {
                var gap = 4;
                var h = 12;

                /* .5 to overlap the line width */
                writer.WriteLine($"<path d='M{x}.5 {y - (h / 2)} v{h} m {gap} 0 v{-h}' class='station'/>");
            }

            private void Style()
            {
                using (writer.TagIndent("style"))
                {
                    EmbeddedResources.GetCss(writer, typeof(RailSvgFormat));
                }
            }

            private void RenderRule(Tile node, string refBase)
            {
                ctx.Reset(refBase);

                ctx.x = 5;
                ctx.y = U.Scale(node.Ascender + 1);
                RenderStation(ctx.x, ctx.y);

                ctx.x = U.Scale(1);
                ctx.AddH(U.Scale(2));

                ctx.x = U.Scale(node.Width + 3);
                ctx.AddH(U.Scale(2));

                ctx.x += U.Scale(2);
                RenderStation(ctx.x, ctx.y);

                ctx.x = U.Scale(3);
                ctx.y = U.Scale(node.Ascender + 1);
                RenderNode(node);

                /*
                 * Consolidate adjacent nodes of the same type.
                 */
                ctx.path.Consolidate();

                var p = ctx.path.ExtractOne();
                while (p != null)
                {
                    writer.Write($"<path d='M{p.x0} {p.y0}");
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

                        p = ctx.path.ExtractNext(p.x1, p.y1);

                    }
                    while (p != null);

                    writer.WriteLine("'/>");

                    p = ctx.path.ExtractOne();
                }
            }

            private void Render(List<(string name, Tile tile)> nodes)
            {
                var width = 0;
                var height = 0;

                foreach (var tile in nodes.Select(node => node.tile))
                {
                    if (tile.Width > width)
                    {
                        width = tile.Width;
                    }
                    height += tile.Ascender + tile.Descender + 6;
                }

                width += 12;
                height += 5;

                writer.WriteLine("<?xml version='1.0' encoding='utf-8'?>");
                writer.WriteLine("<svg");
                writer.WriteLine("    xmlns='http://www.w3.org/2000/svg'");
                writer.WriteLine("    xmlns:xlink='http://www.w3.org/1999/xlink'");
                writer.WriteLine();
                writer.WriteLine($"   width='{U.Scale(width)}' height='{U.Scale(height + 6)}'>");
                using (writer.Indent())
                {
                    Style();
                    writer.WriteLine();
                    var y = 0;
                    foreach (var (name, tile) in nodes)
                    {
                        writer.WriteLine($"<g transform='translate({U.Scale(4)} {U.Scale(y + 3)})'>");
                        using (writer.Indent())
                        {
                            writer.WriteLine($"<text x='{U.Scale(-4)}' y='{U.Scale(0)}'>{name}:</text>");

                            RenderRule(tile, string.Empty);

                        }
                        writer.WriteLine("</g>");
                        writer.WriteLine();

                        y += tile.Ascender + tile.Descender + 6;
                    }
                }
                writer.WriteLine("</svg>");
            }
        }
    }
}