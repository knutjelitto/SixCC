namespace SixBot.Ast
{
    internal class IsFragmentWalker : PredicateWalker
    {
        public IsFragmentWalker()
            : base(ex => ex.IsFragment, (ex, value) => ex.IsFragment = value)
        {
        }

        protected override void Visit(Rule rule)
        {
            base.Visit(rule);
            Set(rule, rule.Expression.IsRegex);
        }
    }
}
