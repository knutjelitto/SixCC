using SixTools.Ast;

namespace SixTools.Formats
{
    public class HtmlFormat : AstWalker, IFormat
    {
        private readonly Grammar grammar;
        private readonly Writer writer;
        private readonly bool xhtml;

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
                writer.WriteLine($"<dt><a name='{rule.Name}'>{rule.Name}</a>:</dt>");
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
                                writer.WriteLine("<span class='pipe'> | </span>");
                            }
                            more = true;
                            Walk(term);
                        }
                    }
                    else
                    {
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
                    writer.Write("<span class='pipe'> | </span>");
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
                    writer.Write("<span class='cat'> </span>");
                }
                more = true;
                writer.Write("<span class='alt'>");
                Walk(sub);
                writer.WriteLine("</span>");
            }
        }

        public override void Visit(TermNot term)
        {
            writer.Write("<span class='not'>~</span> ");
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
                writer.Write($"<span class='token'>{term.Text}</span>");
            }
        }

        public override void Visit(TermLiteral term)
        {
            writer.Write($"<tt class='literal cs'>&OpenCurlyQuote;{Esc.Html(term.Text)}&CloseCurlyQuote;</tt>");
        }

        public override void Visit(TermRange term)
        {
            Walk(term.Start);
            writer.Write(" <span class='range'>..</span> ");
            Walk(term.Stop);
        }

        public override void Visit(TermOptional term)
        {
            Repeat(term.Term, "?");
        }

        public override void Visit(TermOneOrMore term)
        {
            Repeat(term.Term, "+");
        }

        public override void Visit(TermZeroOrMore term)
        {
            Repeat(term.Term, "*");
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
                writer.WriteLine("	text-transform: uppercase;");
                writer.WriteLine("	background-color: red;");
                writer.WriteLine("	color: yellow;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf span.cat {");
                writer.WriteLine("	margin-right: 0.5ex;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf dd > span.pipe {");
                writer.WriteLine("	float: left;");
                writer.WriteLine("	width: 1ex;");
                writer.WriteLine("	margin-left: -1.8ex;");
                writer.WriteLine("	text-align: right;");
                writer.WriteLine("	font-weight: bold;");
                writer.WriteLine("	padding-right: 0.8ex; /* about the width of a space */");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf dt {");
                writer.WriteLine("	display: block;");
                writer.WriteLine("	min-width: 8em;");
                writer.WriteLine("	padding-right: 1em;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf a.reference {");
                writer.WriteLine("	text-decoration: none;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("dl.bnf a.reference:hover {");
                writer.WriteLine("	text-decoration: underline;");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("/* page stuff */");
                writer.WriteLine("dl.bnf { margin: 1em 2em; }");
                writer.WriteLine("dl.bnf dt { margin: 0.25em 0; }");
                writer.WriteLine("dl.bnf dd { margin-left: 2em; }");
            }
        }
    }
}
