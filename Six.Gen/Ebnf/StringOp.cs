using Six.Ast;

namespace Six.Gen.Ebnf
{
    public class StringOp : Operator
    {
        public StringOp(string text)
        {
            Text = text;
        }

        public string Text { get; }

        protected override string DumpHead => Text.Esc();
    }
}
