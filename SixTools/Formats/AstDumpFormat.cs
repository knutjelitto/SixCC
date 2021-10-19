using SixTools.Ast;

namespace SixTools.Formats
{
    public class AstDumpFormat : AstWalker, IFormat
    {
        private readonly Grammar grammar;
        private readonly Writer writer;

        public AstDumpFormat(Grammar grammar, Writer writer)
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
            writer.WriteLine($"\"{Esc.Full(term.Text)}\"");
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

        public override void Visit(TermOptional term)
        {
            writer.WriteLine("optional");
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
    }
}
