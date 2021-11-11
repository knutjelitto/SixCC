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

        public override void Visit(TokenTerm term)
        {
            if (rules.TryGetValue(term.Text, out var rule))
            {
                rule.InUse = true;
                term.IsReference = true;
            }
        }

        protected override void NotImplemented()
        {
        }
    }
}
