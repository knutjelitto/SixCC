namespace Six.Runtime.Matchers
{
    public sealed class Not : Structural
    {
        public Not(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            // match without any leading space

            Assert(Dfa != null);

            if (Dfa.TryMatch(context.Start, out var next))
            {
                if (next == context.Start)
                {
                    context.Success(context.Start);
                }
            }
            else
            {
                context.Success(context.Start);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
