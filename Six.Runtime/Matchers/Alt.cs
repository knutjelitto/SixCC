namespace Six.Runtime.Matchers
{
    public sealed class Alt : Structural
    {
        public Alt(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            foreach (var matcher in this)
            {
                matcher.Match(context.Start, context.Success);
            }
        }
    }
}
