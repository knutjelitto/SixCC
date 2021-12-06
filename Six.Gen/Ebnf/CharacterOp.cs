using Six.Ast;

namespace Six.Gen.Ebnf
{
    public sealed class CharacterOp : Operator
    {
        public CharacterOp(ILocation location, Codepoint codepoint)
            : base(location)
        {
            Codepoint = codepoint;
        }

        public Codepoint Codepoint { get; }

        protected override string DumpHead => $"cp({Codepoint.ToString().Esc()})";
    }
}
