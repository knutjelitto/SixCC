using Six.Ast;

namespace Six.Gen.Ebnf
{
    public sealed class RangeOp : CoreOp
    {
        public RangeOp(ILocation location, Codepoint codepoint1, Codepoint codepoint2)
            : base(location)
        {
            Codepoint1 = codepoint1;
            Codepoint2 = codepoint2;
        }

        public Codepoint Codepoint1 { get; }
        public Codepoint Codepoint2 { get; }

        protected override string DumpHead => $"range({Codepoint1.ToString().Esc()},{Codepoint2.ToString().Esc()})";
    }
}
