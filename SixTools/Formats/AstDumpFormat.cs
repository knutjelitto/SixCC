using Six.Core;
using SixTools.Ast;
using SixTools.Helpers;

namespace SixTools.Formats
{
    public class AstDumpFormat : IFormat
    {
        public string DebugExtension => ".txt";
        public string FormatName => "ast-dump";

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

            public override void Visit(TerminalTerm term)
            {
                writer.WriteLine("terminal");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(EpsilonTerm term)
            {
                writer.WriteLine("epsilon");
            }

            public override void Visit(AnyTerm term)
            {
                writer.WriteLine("any");
            }

            public override void Visit(TokenTerm term)
            {
                writer.WriteLine($"token {term.Text}");
            }

            public override void Visit(LiteralTerm term)
            {
                writer.WriteLine($"literal '{Esc.Full(term.Text)}'");
            }

            public override void Visit(AlternativesTerm term)
            {
                writer.WriteLine($"alternative");
                using (writer.Indent())
                {
                    foreach (var sub in term)
                    {
                        Walk(sub);
                    }
                }
            }

            public override void Visit(SequenceTerm term)
            {
                writer.WriteLine($"sequence");
                using (writer.Indent())
                {
                    foreach (var sub in term)
                    {
                        Walk(sub);
                    }
                }
            }

            public override void Visit(ZeroOrOneTerm term)
            {
                writer.WriteLine("zero-or-one");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(OneOrMoreTerm term)
            {
                writer.WriteLine("one-or-more");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(ZeroOrMoreTerm term)
            {
                writer.WriteLine("zero-or-more");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(ClampedTerm term)
            {
                writer.WriteLine("group");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(NotTerm term)
            {
                writer.WriteLine("not");
                using (writer.Indent())
                {
                    Walk(term.Inner);
                }
            }

            public override void Visit(GroupTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(RangeTerm term)
            {
                writer.WriteLine("range");
                using (writer.Indent())
                {
                    Walk(term.Start);
                    Walk(term.Stop);
                }
            }
        }
    }
}