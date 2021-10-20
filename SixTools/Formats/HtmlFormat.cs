using SixTools.Ast;

namespace SixTools.Formats
{
    public class HtmlFormat : AstWalker, IFormat
    {
        private readonly Grammar grammar;
        private readonly Writer writer;
        private readonly bool xhtml;

        const string group_star = "*";
        const string group_plus = "+";
        const string group_option = "?";

        public HtmlFormat(Grammar grammar, Writer writer, bool xhtml)
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
        public string PreferedExtension => ".html";

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
                var klass = rule.InUse ? "" : " class='error'";

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
                                writer.WriteLine("<br/>");
                                writer.WriteLine("<span class='pipe'>|</span>");
                            }
                            else
                            {
                                writer.WriteLine("<span class='pipe'>|</span>");
                            }
                            more = true;
                            Walk(term);
                        }
                    }
                    else
                    {
                        writer.WriteLine("<span class='pipe'>:</span>");
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
                    writer.Write("<span class='alt'>|</span>");
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
            writer.Write("<span class='not'>&not; </span>");
            Walk(term.Term);
        }

        public override void Visit(TermEmpty term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermToken term)
        {
            if (term.IsReference)
            {
                writer.Write($"<a href='#{term.Text}' class='reference'>{term.Text}</a>");
            }
            else
            {
                writer.Write($"<span class='token error'>{term.Text}</span>");
            }
        }

        public override void Visit(TermLiteral term)
        {
            writer.Write($"&OpenCurlyQuote;<span class='literal'>{Esc.Html(term.Text)}</span>&CloseCurlyQuote;");
        }

        public override void Visit(TermRange term)
        {
            Walk(term.Start);
            writer.Write("<span class='range'>&mldr;</span>");
            Walk(term.Stop);
        }

        public override void Visit(TermOptional term)
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
            writer.Write($"<span class='rep'>{repeat}</span>");
        }

        private void Style()
        {
            using (writer.TagIndent("style"))
            {
                writer.WriteLine("dl.bnf span.token {");
                writer.WriteLine("	padding-left: 0.3em;");
                writer.WriteLine("	padding-right: 0.3em;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf span.error {");
                writer.WriteLine("	border-radius: 0.4em;");
                writer.WriteLine("	border-width: 0;");
                writer.WriteLine("	outline: 5px dotted orangered;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf span.warning {");
                writer.WriteLine("	border-radius: 0.4em;");
                writer.WriteLine("	border-width: 0;");
                writer.WriteLine("	outline: 5px dotted gold;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf span.cat {");
                writer.WriteLine("	margin-left: 0.0em;");
                writer.WriteLine("	margin-right: 0.1em;");
                writer.WriteLine("}");
                writer.WriteLine("dl.bnf span.range {");
                writer.WriteLine("	margin-right: 0.3em;");
                writer.WriteLine("	margin-left: 0.3em;");
                writer.WriteLine("}");
                writer.WriteLine("dl.bnf span.literal {");
                writer.WriteLine("	font-family: monospace;");
                writer.WriteLine("	font-size: 1.2em;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf span.control {");
                writer.WriteLine("	font-family: monospace;");
                writer.WriteLine("	font-size: 0.55em;");
                writer.WriteLine("	font-weight: bold;");
                writer.WriteLine("	background-color: lightgrey;");
                writer.WriteLine("	padding-left: 0.1em;");
                writer.WriteLine("	padding-right: 0.1em;");
                writer.WriteLine("	margin-left: 0.1em;");
                writer.WriteLine("	margin-right: 0.1em;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf dd > span.pipe {");
                writer.WriteLine("	margin-right: 0.3em;");
                writer.WriteLine("}");
                writer.WriteLine("dl.bnf dd > span.alt {");
                writer.WriteLine("	margin-right: 0.3em;");
                writer.WriteLine("	margin-left: 0.3em;");
                writer.WriteLine("	text-align: center;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf dt {");
                writer.WriteLine("	display: block;");
                writer.WriteLine("	background-color: aliceblue;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf a.reference:link {");
                writer.WriteLine("	color: green;");
                writer.WriteLine("	text-decoration: none;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf a.reference:visited {");
                writer.WriteLine("	color: darkgreen;");
                writer.WriteLine("	text-decoration: none;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf a.reference:hover {");
                writer.WriteLine("	text-decoration: underline;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("/* page stuff */");
                writer.WriteLine("dl.bnf {");
                writer.WriteLine("	margin: 1em 2em;");
                writer.WriteLine("	font-family: sans-serif;");
                writer.WriteLine("	padding: 0.5ex;");
                writer.WriteLine("	background-color: aliceblue;");
                writer.WriteLine("}");
                writer.WriteLine("dl.bnf dt { margin: 0.25em 0; }");
                writer.WriteLine("dl.bnf dd { margin-left: 2em; }");

                writer.WriteLine("dl.bnf span.tooltip {");
                writer.WriteLine("	margin: 1em 2em;");
                writer.WriteLine("	font-family: sans-serif;");
                writer.WriteLine("	padding: 0.5ex;");
                writer.WriteLine("	background-color: aliceblue;");
                writer.WriteLine("}");
            }
        }
    }
}
