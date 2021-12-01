namespace Six.Runtime.Matchers
{
    public record Alt(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            foreach (var matcher in Matchers)
            {
                matcher.Match(cursor, continuation);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
