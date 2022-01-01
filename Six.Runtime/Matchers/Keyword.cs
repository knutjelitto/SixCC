namespace Six.Runtime.Matchers
{
    public sealed class Keyword : Token
    {
        public Keyword(ImplementationCore core, int id, string name, string text)
            : base(core, id, name)
        {
            Text = text;
        }

        public string Text { get; }

        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            var idNext = Core.__MatchKeyword(context.Core);

            var length = idNext.Offset - context.Core.Offset;

            if (length == Text.Length)
            {
                if (context.Core.Source.GetText(context.Core.Offset, length) == Text)
                {
                    if (Text == "see")
                    {
                        Assert(true);
                    }
                    context.Success(idNext);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
