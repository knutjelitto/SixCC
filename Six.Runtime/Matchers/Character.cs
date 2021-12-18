namespace Six.Runtime.Matchers
{
    public sealed record Character(ImplementationCore Core, int Id, string Name, int Codepoint) : Token(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.At == Codepoint)
            {
                context.Success(context.Core.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
