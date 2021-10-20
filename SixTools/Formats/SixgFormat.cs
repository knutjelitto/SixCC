using SixTools.Ast;

namespace SixTools.Formats
{
    public class SixgFormat : AstWalker, IFormat
    {
        private readonly Grammar grammar;
        private readonly Writer writer;

        public SixgFormat(Grammar grammar, Writer writer)
        {
            this.grammar = grammar;
            this.writer = writer;
        }

        public void Format()
        {
            Walk(grammar);
        }
        public string PreferedExtension => ".sixg";

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
                if (rule.Term is TermAlternatives alt)
                {
                    var more = false;
                    foreach (var term in alt.Terms)
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

        public override void Visit(TermAlternatives term)
        {
            Spaced(term.Terms, " | ");
        }

        public override void Visit(TermSequence term)
        {
            Spaced(term.Terms, " ");
        }

        public override void Visit(TermGroup term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermEmpty term)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TermToken term)
        {
            writer.Write($"{term.Text}");
        }

        public override void Visit(TermLiteral term)
        {
            writer.Write($"\'{Esc.Full(term.Text)}\'");
        }

        public override void Visit(TermRange term)
        {
            Walk(term.Start);
            writer.Write($" .. ");
            Walk(term.Stop);
        }

        public override void Visit(TermOptional term)
        {
            Walk(term.Term);
            writer.Write("?");
        }

        public override void Visit(TermOneOrMore term)
        {
            Walk(term.Term);
            writer.Write("+");
        }

        public override void Visit(TermZeroOrMore term)
        {
            Walk(term.Term);
            writer.Write("*");
        }

        public override void Visit(TermClamped term)
        {
            writer.Write("(");
            Walk(term.Term);
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

        public override void Visit(TermNot term)
        {
            throw new NotImplementedException();
        }
    }
}
