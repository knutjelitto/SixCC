using Six.Ast;

namespace Six.Gen.Ebnf
{
    public sealed class CharacterOp : Operator
    {
        public CharacterOp(Codepoint codepoint)
        {
            Codepoint = codepoint;
        }

        public Codepoint Codepoint { get; }

        protected override string DumpHead => $"cp({Codepoint.ToString().Esc()})";
    }
}
