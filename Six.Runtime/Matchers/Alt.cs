namespace Six.Runtime.Matchers
{
    public sealed record Alt(ImplementationCore Core, int Id, string Name) : Structural(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            foreach (var matcher in this)
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
