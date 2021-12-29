using Six.Runtime.Dfa;

namespace Six.Runtime.Matchers
{
    public sealed class Set : Token
    {
        public Set(ImplementationCore core, int id, string name, Dfa.DfaSet dfaSet)
            : base(core, id, name)
        {
            DfaSet = dfaSet;
        }

        public DfaSet DfaSet { get; }

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
