namespace SixTools.Ast
{
    internal class GrammarReferencer : AstWalker
    {
        private readonly Dictionary<string, Rule> rules = new();

        public override void Walk(Grammar grammar)
        {
            foreach (var rule in grammar.Rules)
            {
                if (rule.Name.Text[0] == '%')
                {
                    rule.InUse = true;
                }
                rules.Add(rule.Name.Text, rule);
            }
            if (grammar.Rules.Count > 0)
            {
                grammar.Rules[0].InUse = true;
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

        public override void Visit(TermEpsilon term)
        {
        }

        public override void Visit(TermAny term)
        {
        }

        public override void Visit(TermToken term)
        {
            if (rules.TryGetValue(term.Text, out var rule))
            {
                rule.InUse = true;
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

        public override void Visit(TermZeroOrOne term)
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
