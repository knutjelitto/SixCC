using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Rails;
using SixTools.Tiles;

#pragma warning disable CA1822 // Mark members as static
//#pragma warning disable IDE0051 // Remove unused private members

namespace SixTools.Formats.RailSvg
{
    public class RailSvgFormat : IFormat
    {
        public string DebugExtension => ".svg";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
        }

        public enum Variant
        {
            SVG,
            HTML,
            XHTML,
        }

        private class Formatter : SvgFormatter
        {
            public Formatter(Grammar grammar, Writer writer)
                : base(grammar, writer)
            {
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

                RenderSvgDocument(tiles);
            }

            private void RenderSvgDocument(List<(string name, Tile tile)> nodes)
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

                width += 10;
                height -= 3;

                writer.WriteLine($"<?xml version='1.0' encoding='utf-8'?>");
                writer.WriteLine($"<svg");
                writer.WriteLine($"    xmlns='http://www.w3.org/2000/svg'");
                writer.WriteLine($"    xmlns:xlink='http://www.w3.org/1999/xlink'");
                writer.WriteLine();
                writer.WriteLine($"    width='{U.Scale(width)}' height='{U.Scale(height)}'>");
                using (writer.Indent())
                {
                    ProvideStyle();
                    writer.WriteLine();
                    var y = 0;
                    foreach (var (name, tile) in nodes)
                    {
                        writer.WriteLine($"<g id='{name}' transform='translate({U.Scale(4)} {U.Scale(y + 1)})'>");
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
}