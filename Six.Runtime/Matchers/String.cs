namespace Six.Runtime.Matchers
{
    public record String(ImplementationCore Core, int Id, string Name, string Text) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Core.__MatchToken(context, current =>
            {
                if (current.Start.Match(Text))
                {
                    current.Success(current.Start.Advance(Text.Length));
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
