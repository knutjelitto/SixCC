using SixTools.Ast;
using SixTools.Helpers;

namespace SixTools.Formats
{
    public class AstDumpFormat : IFormat
    {
        public string DebugExtension => ".ast-dump.txt";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
        }

        private class Formatter : AstWalker
        {
            private readonly Grammar grammar;
            private readonly Writer writer;

            public Formatter(Grammar grammar, Writer writer)
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

            public override void Visit(TermEpsilon term)
            {
                writer.WriteLine("epsilon");
            }

            public override void Visit(TermAny term)
            {
                writer.WriteLine("any");
            }

            public override void Visit(TermToken term)
            {
                writer.WriteLine($"token {term.Text}");
            }

            public override void Visit(TermLiteral term)
            {
                writer.WriteLine($"literal '{Esc.Full(term.Text)}'");
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

            public override void Visit(TermZeroOrOne term)
            {
                writer.WriteLine("zero-or-one");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }

            public override void Visit(TermOneOrMore term)
            {
                writer.WriteLine("one-or-more");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }

            public override void Visit(TermZeroOrMore term)
            {
                writer.WriteLine("zero-or-more");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }

            public override void Visit(TermClamped term)
            {
                writer.WriteLine("group");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }

            public override void Visit(TermGroup term)
            {
                throw new NotImplementedException();
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

            public override void Visit(TermNot term)
            {
                writer.WriteLine("not");
                using (writer.Indent())
                {
                    Walk(term.Term);
                }
            }
        }
    }
}