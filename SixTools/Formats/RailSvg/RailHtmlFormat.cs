using SixTools.Ast;
using SixTools.Rails;
using SixTools.Tiles;

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
                                writer.WriteLine($"<span class='rulehead'><a name='{name}'>{name}:</a></span>");

                                var h = U.Scale(tile.Height);
                                var w = U.Scale(tile.Width + 6);
                                writer.WriteLine($"<svg class='railroad' width='{w}' height='{h + 2}'>");
                                using (writer.Indent())
                                {
                                    RenderRule(tile, string.Empty, 1);
                                }
                                writer.WriteLine("</svg></br></br>");
                            }
                        }
                    }
                }
            }
        }
    }
}