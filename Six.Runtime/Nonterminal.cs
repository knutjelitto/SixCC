namespace Six.Runtime
{
    public sealed record Nonterminal(IRunImplementation Context, int Id, string Descriptor, params int[] ProductionIds)
        : Symbol(Context, Id, Descriptor)
    {
        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            foreach (var productionId in ProductionIds)
            {
                var production = Context.Productions[productionId];
                production.Match(cursor, continueWith);
            }
        }

        public override string ToString()
        {
            return $"{{nonterminal {Descriptor}}}";
        }
    }
}
