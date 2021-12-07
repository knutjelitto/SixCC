namespace Six.Runtime.Matchers
{
    public record Alt(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            foreach (var matcher in Matchers)
            {
                matcher.Match(context.Start, context.Success);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
