using Six.Ast;

namespace Six.Gen.Ebnf
{
    public class RangeOp : Operator
    {
        public RangeOp(Codepoint codepoint1, Codepoint codepoint2)
        {
            Codepoint1 = codepoint1;
            Codepoint2 = codepoint2;
        }

        public Codepoint Codepoint1 { get; }
        public Codepoint Codepoint2 { get; }

        protected override string DumpHead => $"{Codepoint1.ToString().Esc()} .. {Codepoint2.ToString().Esc()}";
    }
}
