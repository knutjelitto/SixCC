namespace SixTools.Ast
{
    internal class GrammarReferencer : AstWalker
    {
        private readonly HashSet<string> rules = new();

        public override void Walk(Grammar grammar)
        {
            foreach (var rule in grammar.Rules)
            {
                _ = rules.Add(rule.Name.Text);
            }

            base.Walk(grammar);
        }
        public override void Visit(TermAlternatives term)
        {
            Walk(term);
        }

        public override void Visit(TermSequence term)
        {
            Walk(term);
        }

        public override void Visit(TermEmpty term)
        {
        }

        public override void Visit(TermToken term)
        {
            if (rules.Contains(term.Text))
            {
                term.IsReference = true;
            }
        }

        public override void Visit(TermLiteral term)
        {
        }

        public override void Visit(TermRange term)
        {
        }

        public override void Visit(TermGroup term)
        {
            Walk(term.Term);
        }

        public override void Visit(TermClamped term)
        {
            Walk(term.Term);
        }

        public override void Visit(TermOptional term)
        {
            Walk(term.Term);
        }

        public override void Visit(TermOneOrMore term)
        {
            Walk(term.Term);
        }

        public override void Visit(TermZeroOrMore term)
        {
            Walk(term.Term);
        }

        public override void Visit(TermNot term)
        {
            Walk(term.Term);
        }
    }
}
