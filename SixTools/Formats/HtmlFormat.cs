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

        public override void Walk(Grammar grammar)
        {
            using (writer.TagIndent("head"))
            {
                if (xhtml)
                {
                    writer.WriteLine("<meta charset='utf-8'/>");
                }
                using (writer.TagIndent("style"))
                {
                    writer.WriteLine("dl.bnf span.token {");
                    writer.WriteLine("	text-transform: uppercase;");
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
                    writer.WriteLine("	padding-right: .8ex; /* about the width of a space */");
                    writer.WriteLine("}");
                    writer.WriteLine("");
                    writer.WriteLine("dl.bnf dt {");
                    writer.WriteLine("	display: block;");
                    writer.WriteLine("	min-width: 8em;");
                    writer.WriteLine("	padding-right: 1em;");
                    writer.WriteLine("}");
                    writer.WriteLine("");
                    writer.WriteLine("dl.bnf a.rule {");
                    writer.WriteLine("	text-decoration: none;");
                    writer.WriteLine("}");
                    writer.WriteLine("");
                    writer.WriteLine("dl.bnf a.rule:hover {");
                    writer.WriteLine("	text-decoration: underline;");
                    writer.WriteLine("}");
                    writer.WriteLine("");
                    writer.WriteLine("/* page stuff */");
                    writer.WriteLine("dl.bnf { margin: 2em 4em; }");
                    writer.WriteLine("dl.bnf dt { margin: 0.25em 0; }");
                    writer.WriteLine("dl.bnf dd { margin-left: 2em; }");
                }
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
            throw new NotImplementedException();
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

        public override void Visit(TermEmpty term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermIdentifier term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermLiteral term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermRange term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermOptional term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermOneOrMore term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermZeroOrMore term)
        {
            throw new NotImplementedException();
        }
    }
}
