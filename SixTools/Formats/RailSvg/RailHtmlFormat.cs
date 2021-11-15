using Six.Core;
using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Rails;
using SixTools.Tiles;

namespace SixTools.Formats.RailSvg
{
    public class RailHtmlFormat : IFormat
    {
        public string DebugExtension => ".html";
        public string FormatName => "svg-html";

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

                foreach (var rule in Grammar.Rules)
                {
                    var node = RailMaker.Make(rule.Term);
                    var tile = TileMaker.Make(node, D);

                    tiles.Add((rule.Name.Text, tile));
                }

                RenderHtmlDocument(tiles);
            }

            private void RenderHtmlDocument(List<(string name, Tile tile)> nodes)
            {
                Writer.WriteLine("<!DOCTYPE html>");
                using (Writer.TagIndent("html"))
                {
                    using (Writer.TagIndent("head"))
                    {
                        /*
                        */
                        Writer.Tagged("title", $"Grammar of {Grammar.Name?.Text ?? "<unknown>"}");
                        Writer.TagClosedLine("meta", "", "charset='utf-8'");
                        Writer.TagClosed("meta", "", "name='viewport' content='width=device-width, initial-scale=1'");
                        //writer.TagClosedLine("link", "", "rel='stylesheet'", "href='https://cdn.rawgit.com/Chalarangelo/mini.css/v3.0.1/dist/mini-default.min.css'");
                        //writer.TagClosedLine("link", "", "rel='stylesheet'", "href='https://cdn.jsdelivr.net/npm/bulma@0.9.3/css/bulma.min.css'");
                        //writer.TagClosedLine("link", "", "rel='stylesheet'", "href='https://unpkg.com/@primer/css@^16.0.0/dist/primer.css'");
                        //writer.TagClosedLine("link", "", "rel='stylesheet'", "href='https://unpkg.com/tachyons/css/tachyons.min.css'");

                        //writer.WriteLine("<link rel='stylesheet' href='https://unpkg.com/spectre.css/dist/spectre.min.css'/>");
                        //writer.WriteLine("<link rel='stylesheet' href='https://unpkg.com/spectre.css/dist/spectre-exp.min.css'/>");
                        //writer.WriteLine("<link rel='stylesheet' href='https://unpkg.com/spectre.css/dist/spectre-icons.min.css'/>");

                        Writer.WriteLine("<link rel='preconnect' href='https://fonts.googleapis.com'>");
                        Writer.WriteLine("<link rel='preconnect' href='https://fonts.gstatic.com' crossorigin>");
                        Writer.WriteLine("<link rel='stylesheet' href='https://fonts.googleapis.com/css2?family=Roboto+Mono&display=swap'>");
                        Writer.WriteLine("<link rel='stylesheet' href='https://fonts.googleapis.com/css2?family=Roboto&display=swap'>");
                        ProvideStyle();
                    }
                    using (Writer.TagIndent("body"))
                    {
                        using (Writer.TagIndent("article"))
                        {
                            foreach (var (name, tile) in nodes)
                            {
                                using (Writer.TagIndent("div", "block"))
                                {
                                    using (Writer.TagIndent("div", "card"))
                                    {
                                        using (Writer.TagIndent("header", "card-header"))
                                        {
                                            using (Writer.TagIndent("p", "card-title h6", $"id='{Esc.HtmlEntity(name)}'"))
                                            {
                                                Writer.WriteLine(Esc.HtmlEntity(name));
                                            }
                                        }

                                        using (Writer.TagIndent("div", "card-body"))
                                        {
                                            var height = tile.Height;
                                            var width = tile.Width + D[6];
                                            using (Writer.TagIndent("svg", "railroad", $"width='{width + 2}' height='{height + 2}'"))
                                            {
                                                using (Writer.TagIndent("g", "railroad", "transform='translate(1,1)'"))
                                                {
                                                    RenderRule(tile, string.Empty);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}