namespace Six.Runtime.Matchers
{
    public sealed record PlainRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            Assert(Count == 1);

            var matcher = this[0];

            matcher.Match(context.Start, context.Success);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
