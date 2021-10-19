using SixTools.Ast;

namespace SixTools.Formats
{
    public class AstDump : AstWalker, IFormat
    {
        private readonly Grammar grammar;
        private readonly Writer writer;

        public AstDump(Grammar grammar, Writer writer)
        {
            this.grammar = grammar;
            this.writer = writer;
        }

        public void Format()
        {
            Walk(grammar);
        }

        public override void Walk(Grammar grammar)
        {
            writer.WriteLine(grammar.Name.Text);
            using (writer.Indent())
            {
                foreach (var rule in grammar.Rules)
                {
                    Walk(rule);
                }
            }
        }

        public override void Walk(Rule rule)
        {
            writer.WriteLine(rule.Name.Text);
            using (writer.Indent())
            {
                Walk(rule.Term);
            }
        }

        public override void Visit(TermEmpty term)
        {
            writer.WriteLine("-epsilon-");
        }

        public override void Visit(TermIdentifier term)
        {
            writer.WriteLine(term.Text);
        }

        public override void Visit(TermLiteral term)
        {
            writer.WriteLine($"\"{Escape(term.Text)}\"");
        }

        public override void Visit(TermAlternatives term)
        {
            writer.WriteLine($"alternative");
            using (writer.Indent())
            {
                foreach (var sub in term.Terms)
                {
                    Walk(sub);
                }
            }
        }

        public override void Visit(TermSequence term)
        {
            writer.WriteLine($"sequence");
            using (writer.Indent())
            {
                foreach (var sub in term.Terms)
                {
                    Walk(sub);
                }
            }
        }

        public override void Visit(TermGroup term)
        {
            if (term.Min == 1 && term.Max == 1)
            {
                writer.WriteLine("group");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }
            else if (term.Min == 1 && term.Max == 0)
            {
                writer.WriteLine("one-or-more");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }
            else if (term.Min == 0 && term.Max == 0)
            {
                writer.WriteLine("zero-or-more");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }
            else if (term.Min == 0 && term.Max == 1)
            {
                writer.WriteLine("optional");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override void Visit(TermRange term)
        {
            writer.WriteLine("range");
            using (writer.Indent())
            {
                Walk(term.Start);
                Walk(term.Stop);
            }
        }

        private static string Escape(string literal)
        {
            return string.Join(string.Empty, literal.Select(c => esc(c)));

            static string esc(char c)
            {
                switch(c)
                {
                    case '\a':
                        return "\\a";
                    case '\b':
                        return "\\b";
                    case '\x1B':
                        return "\\e";
                    case '\f':
                        return "\\f";
                    case '\t':
                        return "\\t";
                    case '\v':
                        return "\\v";
                    case '\r':
                        return "\\r";
                    case '\n':
                        return "\\n";
                    case '\"':
                        return "\\\"";
                    case '\'':
                        return "\\\'";
                    default:
                        if (c < ' ')
                        {
                            return $"\\x{(int)c:X2}";
                        }
                        else if (char.IsAscii(c))
                        {
                            return c.ToString();
                        }
                        return $"\\u{(int)c:X4}";
                }
            }
        }
    }
}
