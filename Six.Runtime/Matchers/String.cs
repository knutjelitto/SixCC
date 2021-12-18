namespace Six.Runtime.Matchers
{
    public sealed record String(ImplementationCore Core, int Id, string Name, string Text) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.Match(Text))
            {
                context.Success(context.Core.Advance(Text.Length));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
