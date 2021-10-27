using SixTools.Ast;

namespace SixTools.Formats
{
    public class WsnFormat : IFormat
    {
        public string DebugExtension => ".wsn";

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
                if (rule.Term is TermAlternatives alt)
                {
                    var more = false;
                    foreach (var term in alt.Terms)
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

            public override void Visit(TermAlternatives term)
            {
                Spaced(term.Terms, "|");
            }

            public override void Visit(TermSequence term)
            {
                Spaced(term.Terms, "");
            }

            public override void Visit(TermGroup term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermEpsilon term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermToken term)
            {
                writer.Write($" {term.Text}");
            }

            public override void Visit(TermLiteral term)
            {
                writer.Write($" \"{Escape(term.Text)}\"");
            }

            public override void Visit(TermRange term)
            {
                writer.Write(" (");
                Spaced(Spread(term), "|");
                writer.Write(" )");
            }

            public override void Visit(TermClamped term)
            {
                writer.Write(" (");
                Walk(term.Term);
                writer.Write(" )");
            }

            public override void Visit(TermZeroOrOne term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermOneOrMore term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermZeroOrMore term)
            {
                writer.Write(" {");
                Walk(term.Term);
                writer.Write(" }");
            }

            private static IEnumerable<TermLiteral> Spread(TermRange range)
            {
                var start = range.Start.Text.Single();
                var stop = range.Stop.Text.Single();

                for (var c = start; c <= stop; c++)
                {
                    yield return new TermLiteral(c);
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

            public override void Visit(TermNot term)
            {
                throw new NotImplementedException();
            }

            public override void Visit(TermAny term)
            {
                throw new NotImplementedException();
            }
        }
    }
}
