namespace Six.Runtime.Matchers
{
    public record Set(ImplementationCore Core, int Id, string Name, Dfa.DfaSet DfaSet) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Core.__MatchToken(context, current =>
            {
                if (DfaSet.Match(current.Start.At))
                {
                    current.Success(current.Start.Advance(1));
                }
            });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
