using Six.Ast;

namespace Six.Gen.Ebnf
{
    public class CodepointOp : Operator
    {
        public CodepointOp(Codepoint codepoint)
        {
            Codepoint = codepoint;
        }

        public Codepoint Codepoint { get; }

        protected override string DumpHead => Codepoint.ToString().Esc();
    }
}
