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
        public bool IsKeyword { get; set; }

        protected override string DumpHead => $"string({Text.Esc()})";
    }
}
