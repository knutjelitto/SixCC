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
            for (var i = 0; i < Matchers.Length; ++i)
            {
                Matchers[i].Match(context.Start, context.Success);
            }
        }
    }
}
