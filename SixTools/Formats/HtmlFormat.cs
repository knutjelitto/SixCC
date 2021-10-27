using SixTools.Ast;
using SixTools.Helpers;

namespace SixTools.Formats
{
    public class HtmlFormat : IFormat
    {
        public string DebugExtension => ".html";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer, true).Format();
        }

        private class Formatter : AstWalker
        {
            private readonly Grammar grammar;
            private readonly Writer writer;
            private readonly bool xhtml;
            private const string group_star = "*";
            private const string group_plus = "+";
            private const string group_option = "?";
            private const string any_dot = "&#x1F784;";
            private const string epsilon = "&epsi;";
            private const string start_literal = "&OpenCurlyQuote;";
            private const string end_literal = "&CloseCurlyQuote;";

            public Formatter(Grammar grammar, Writer writer, bool xhtml)
            {
                this.grammar = grammar;
                this.writer = writer;
                this.xhtml = xhtml;
            }

            public void Format()
            {
                if (xhtml)
                {
                    writer.WriteLine("<?xml version='1.0' encoding='utf-8'?>");
                    writer.WriteLine("<!DOCTYPE html>");
                    writer.WriteLine("<html xml:lang='en' lang='en'");
                    writer.WriteLine("    xmlns='http://www.w3.org/1999/xhtml'");
                    writer.WriteLine("    xmlns:xlink='http://www.w3.org/1999/xlink'>");
                }
                else
                {
                    writer.WriteLine("<!DOCTYPE html>");
                    writer.WriteLine("<html>");
                }

                using (writer.Indent())
                {
                    Walk(grammar);
                }

                writer.WriteLine("</html>");
            }

            public override void Walk(Grammar grammar)
            {
                using (writer.TagIndent("head"))
                {
                    if (xhtml)
                    {
                        writer.WriteLine("<meta charset='utf-8'/>");
                    }
                    Style();
                }
                using (writer.TagIndent("body"))
                {
                    foreach (var rule in grammar.Rules)
                    {
                        Walk(rule);
                    }
                }
            }

            public override void Walk(Rule rule)
            {
                using (writer.TagIndent("dl", "bnf"))
                {
                    var klass = rule.InUse ? "" : " class='warning'";

                    writer.WriteLine($"<dt><span{klass}><a name='{rule.Name}'>{rule.Name}</a><span></dt>");
                    using (writer.TagIndent("dd"))
                    {
                        if (rule.Term is TermAlternatives alt)
                        {
                            var more = false;
                            foreach (var term in alt.Terms)
                            {
                                if (more)
                                {
                                    writer.Write("<br/>");
                                    writer.Write("<span class='toplevel'>|</span>");
                                }
                                else
                                {
                                    writer.Write("<span class='toplevel'>:</span>");
                                }
                                more = true;
                                Walk(term);
                            }
                        }
                        else
                        {
                            writer.Write("<span class='toplevel'>:</span>");
                            Walk(rule.Term);
                        }
                    }
                }
            }

            public override void Visit(TermGroup term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermAlternatives term)
            {
                var more = false;
                foreach (var sub in term.Terms)
                {
                    if (more)
                    {
                        writer.Write("<span class='pipe'>|</span>");
                    }
                    more = true;
                    Walk(sub);
                }
            }

            public override void Visit(TermSequence term)
            {
                var more = false;
                foreach (var sub in term.Terms)
                {
                    if (more)
                    {
                        writer.Write("<span class='cat'>&nbsp;</span>");
                    }
                    more = true;
                    Walk(sub);
                }
            }

            public override void Visit(TermNot term)
            {
                writer.Write("<span class='not'>&not;</span>");
                Walk(term.Term);
            }

            public override void Visit(TermEpsilon term)
            {
                writer.Write($"<span class='token'>{epsilon}</span>");
            }

            public override void Visit(TermAny term)
            {
                writer.Write($"<span class='any'>{any_dot}</span>");
            }

            public override void Visit(TermToken term)
            {
                if (term.IsReference)
                {
                    writer.Write($"<a href='#{term.Text}' class='token'>{term.Text.Replace("-", "&#8209;")}</a>");
                }
                else
                {
                    writer.Write($"<span class='token error'>{term.Text.Replace("-", "&#8209;")}</span>");
                }
            }

            public override void Visit(TermLiteral term)
            {
                writer.Write($"{start_literal}<span class='literal'>{Esc.Html(term.Text)}</span>{end_literal}");
            }

            public override void Visit(TermRange term)
            {
                Walk(term.Start);
                writer.Write("<span class='range'>&mldr;</span>");
                Walk(term.Stop);
            }

            public override void Visit(TermZeroOrOne term)
            {
                Repeat(term.Term, group_option);
            }

            public override void Visit(TermOneOrMore term)
            {
                Repeat(term.Term, group_plus);
            }

            public override void Visit(TermZeroOrMore term)
            {
                Repeat(term.Term, group_star);
            }

            public override void Visit(TermClamped term)
            {
                writer.Write("<span class='clamp'>(</span>");
                Walk(term.Term);
                writer.Write("<span class='clamp'>)</span>");
            }

            private void Repeat(Term term, string repeat)
            {
                Walk(term);
                writer.Write($"<span class='suffix'>{repeat}</span>");
            }

            private void Style()
            {
                using (writer.TagIndent("style"))
                {
                    EmbeddedResources.GetCss(writer, typeof(HtmlFormat));
                }
            }
        }
    }
}