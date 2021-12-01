namespace Six.Runtime.Matchers
{
    public record WhiteRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            Matchers[0].Match(cursor, continueWith);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
