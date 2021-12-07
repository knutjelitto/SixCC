namespace Six.Runtime.Matchers
{
    public sealed record String(ImplementationCore Core, int Id, string Name, string Text) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            var white = Core.__MatchWhite(context.Start);

            if (white.Match(Text))
            {
                context.Success(white.Advance(Text.Length));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
