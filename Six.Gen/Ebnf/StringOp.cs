using Six.Ast;

namespace Six.Gen.Ebnf
{
    public sealed class StringOp : CoreOp
    {
        public StringOp(ILocation location, string text)
            : base(location)
        {
            Text = text;
        }

        public string Text { get; }

        protected override string DumpHead => $"string({Text.Esc()})";
    }
}
