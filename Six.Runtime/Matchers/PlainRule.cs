namespace Six.Runtime.Matchers
{
    public sealed class PlainRule : Rule
    {
        public PlainRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

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
