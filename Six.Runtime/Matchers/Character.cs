namespace Six.Runtime.Matchers
{
    public sealed record Character(ImplementationCore Core, int Id, string Name, int Codepoint) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            var white = Core.__MatchWhite(context.Start);

            if (white.At == Codepoint)
            {
                context.Success(white.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
