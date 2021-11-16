namespace Six.Ast
{
    internal class IsFragmentWalker : PredicateWalker
    {
        public IsFragmentWalker()
            : base(ex => ex.IsFragment, (ex, value) => ex.IsFragment = value)
        {
        }

        protected override void Visit(Rule rule)
        {
            if (rule.IsCompact || rule.IsFragment)
            {
                base.Visit(rule);
            }
        }

        protected override void Visit(Reference reference)
        {
            base.Visit(reference);
            Set(reference.Rule, true);
        }
    }
}
