using SixTools.Ast;

namespace SixTools.Formats
{
    public class WsnFormat : IFormat
    {
        public string DebugExtension => ".wsn";
        public string FormatName => "wsn";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
        }

        private class Formatter : AstWalker
        {
            private readonly Grammar grammar;
            private readonly Writer writer;
            private readonly int maxLenght;

            public Formatter(Grammar grammar, Writer writer)
            {
                this.grammar = grammar;
                this.writer = writer;
                maxLenght = grammar.Rules.Select(r => r.Name.Text.Length).Max();
            }

            public void Format()
            {
                Walk(grammar);
            }

            public override void Walk(Rule rule)
            {
                writer.Write(rule.Name.Text);
                writer.Write(new string(' ', maxLenght - rule.Name.Text.Length));
                writer.Write(" =");
                if (rule.Term is AlternativesTerm alt)
                {
                    var more = false;
                    foreach (var term in alt)
                    {
                        if (more)
                        {
                            writer.WriteLine(); ;
                            writer.Write(new string(' ', maxLenght));
                            writer.Write(" |");
                        }
                        more = true;
                        Walk(term);
                    }
                }
                else
                {
                    Walk(rule.Term);
                }
                writer.WriteLine(" .");
            }

            public override void Visit(AlternativesTerm term)
            {
                Spaced(term, "|");
            }

            public override void Visit(SequenceTerm term)
            {
                Spaced(term, "");
            }

            public override void Visit(GroupTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(EpsilonTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TokenTerm term)
            {
                writer.Write($" {term.Text}");
            }

            public override void Visit(LiteralTerm term)
            {
                writer.Write($" \"{Escape(term.Text)}\"");
            }

            public override void Visit(RangeTerm term)
            {
                writer.Write(" (");
                Spaced(Spread(term), "|");
                writer.Write(" )");
            }

            public override void Visit(ClampedTerm term)
            {
                writer.Write(" (");
                Walk(term.Inner);
                writer.Write(" )");
            }

            public override void Visit(ZeroOrOneTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(OneOrMoreTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(ZeroOrMoreTerm term)
            {
                writer.Write(" {");
                Walk(term.Inner);
                writer.Write(" }");
            }

            private static IEnumerable<LiteralTerm> Spread(RangeTerm range)
            {
                var start = range.Start.Text.Single();
                var stop = range.Stop.Text.Single();

                for (var c = start; c <= stop; c++)
                {
                    yield return new LiteralTerm(c);
                }
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

            private static string Escape(char c)
            {
                return c == '\"' ? "\"\"" : c.ToString();
            }

            private static string Escape(string literal)
            {
                return string.Join(string.Empty, literal.Select(c => Escape(c)));
            }

            public override void Visit(NotTerm term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(AnyTerm term)
            {
                throw new NotImplementedException();
            }
        }
    }
}
