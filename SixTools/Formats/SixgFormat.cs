using SixTools.Ast;
using SixTools.Helpers;

namespace SixTools.Formats
{
    public class SixgFormat : IFormat
    {
        public string DebugExtension => ".sixg";
        public string FormatName => "sixg";

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
                writer.WriteLine($"grammar {grammar.Name.Text};");

                foreach (var rule in grammar.Rules)
                {
                    writer.WriteLine();

                    Walk(rule);
                }
            }

            public override void Walk(Rule rule)
            {
                writer.WriteLine(rule.Name.Text);
                using (writer.Indent())
                {
                    writer.Write(": ");
                    if (rule.Term is AlternativesTerm alt)
                    {
                        var more = false;
                        foreach (var term in alt)
                        {
                            if (more)
                            {
                                writer.WriteLine(); ;
                                writer.Write("| ");
                            }
                            more = true;
                            Walk(term);
                        }
                    }
                    else
                    {
                        Walk(rule.Term);
                    }
                    writer.WriteLine();
                    writer.WriteLine(";");
                }
            }

            public override void Visit(AlternativesTerm term)
            {
                Spaced(term, " | ");
            }

            public override void Visit(SequenceTerm term)
            {
                Spaced(term, " ");
            }

            public override void Visit(GroupTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(EpsilonTerm term)
            {
                writer.Write("<< ε >>");
            }

            public override void Visit(AnyTerm term)
            {
                writer.Write($".");
            }

            public override void Visit(NotTerm term)
            {
                writer.Write($"~");
                Walk(term.Inner);
            }

            public override void Visit(TokenTerm term)
            {
                writer.Write($"{term.Text}");
            }

            public override void Visit(LiteralTerm term)
            {
                writer.Write($"\'{Esc.Full(term.Text)}\'");
            }

            public override void Visit(RangeTerm term)
            {
                Walk(term.Start);
                writer.Write($" .. ");
                Walk(term.Stop);
            }

            public override void Visit(ZeroOrOneTerm term)
            {
                Walk(term.Inner);
                writer.Write("?");
            }

            public override void Visit(OneOrMoreTerm term)
            {
                Walk(term.Inner);
                writer.Write("+");
            }

            public override void Visit(ZeroOrMoreTerm term)
            {
                Walk(term.Inner);
                writer.Write("*");
            }

            public override void Visit(ClampedTerm term)
            {
                writer.Write("(");
                Walk(term.Inner);
                writer.Write(")");
            }

            private void Spaced(IEnumerable<Term> terms, string space)
            {
                var more = false;
                foreach (var term in terms)
                {
                    if (more)
                    {
                        writer.Write(space);
                    }
                    more = true;
                    Walk(term);
                }
            }
        }
    }
}