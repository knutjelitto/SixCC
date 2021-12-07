namespace Six.Runtime.Matchers
{
    public sealed record Set(ImplementationCore Core, int Id, string Name, Dfa.DfaSet DfaSet) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            var white = Core.__MatchWhite(context.Start);

            if (DfaSet.Match(white.At))
            {
                context.Success(white.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
