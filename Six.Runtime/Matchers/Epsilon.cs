namespace Six.Runtime.Matchers
{
    public sealed record Epsilon(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            context.Success(context.Start);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
