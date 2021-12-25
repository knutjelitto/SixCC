namespace Six.Runtime.Matchers
{
    public sealed record Keyword(ImplementationCore Core, int Id, string Name, string Text) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            var idNext = Core.__MatchKeyword(context.Core);

            var length = idNext.Offset - context.Core.Offset;

            if (length == Text.Length)
            {
                if (context.Core.Source.GetText(context.Core.Offset, length) == Text)
                {
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
