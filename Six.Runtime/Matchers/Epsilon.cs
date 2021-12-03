namespace Six.Runtime.Matchers
{
    public record Epsilon(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            context.Success(context.Start);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
