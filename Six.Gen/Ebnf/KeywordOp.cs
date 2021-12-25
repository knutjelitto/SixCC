namespace Six.Gen.Ebnf
{
    public sealed class KeywordOp : CoreOp
    {
        public KeywordOp(ILocation location, string text)
            : base(location)
        {
            Text = text;
        }

        public string Text { get; }

        protected override string DumpHead => $"kw({Text.Esc()})";
    }
}
