namespace Six.Runtime.Matchers
{
    public sealed record Character(ImplementationCore Core, int Id, string Name, int Codepoint) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Core.__MatchToken(context, current =>
            {
                if (current.Start.At == Codepoint)
                {
                    current.Success(current.Start.Advance(1));
                }
                else
                {
                    current.Failure(current.Start);
                }
            });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
