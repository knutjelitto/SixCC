using Six.Ast;

namespace Six.Gen.Ebnf
{
    public sealed class StringOp : Operator
    {
        public StringOp(string text)
        {
            Text = text;
        }

        public string Text { get; }

        protected override string DumpHead => $"string({Text.Esc()})";
    }
}
