using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Rails;
using SixTools.Tiles;

#pragma warning disable CA1822 // Mark members as static
//#pragma warning disable IDE0051 // Remove unused private members

namespace SixTools.Formats.RailSvg
{
    public class RailHtmlFormat : IFormat
    {
        public string DebugExtension => "-svg.html";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
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

                RenderHtmlDocument(tiles);
            }

            private void RenderHtmlDocument(List<(string name, Tile tile)> nodes)
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

                writer.WriteLine("<!DOCTYPE html>");
                using (writer.TagIndent("html"))
                {
                    using (writer.TagIndent("head"))
                    {
                        ProvideStyle();
                    }
                    using (writer.TagIndent("body"))
                    {
                        foreach (var (name, tile) in nodes)
                        {
                            using (writer.TagIndent("section"))
                            {
                                writer.WriteLine($"<span class='rulehead'><a name='{name}'>{name}:</a></h2><br/>");

                                var h = U.Scale(tile.Height + 2);
                                var w = U.Scale(tile.Width + 6);
                                writer.WriteLine($"<svg width='{w}' height='{h}'>");
                                using (writer.Indent())
                                {
                                    RenderRule(tile, string.Empty);
                                }
                                writer.WriteLine("</svg>");
                            }
                        }
                    }
                }
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