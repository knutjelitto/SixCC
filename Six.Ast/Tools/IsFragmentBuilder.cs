namespace Six.Ast
{
    internal class IsFragmentBuilder : PredicateBuilder
    {
        public IsFragmentBuilder()
            : base(ex => ((Symbol)ex).IsFragment, (ex, value) => ((Symbol)ex).IsFragment = value)
        {
        }

        protected override void Visit(Symbol symbol)
        {
            if (symbol.IsCompact || symbol.IsFragment)
            {
                base.Visit(symbol);
            }
        }

        protected override void Visit(Reference reference)
        {
            base.Visit(reference);
            Set(reference.Symbol, true);
        }
    }
}
