namespace Six.Runtime.Matchers
{
    public record Any(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            if (context.Start.At != -1)
            {
                context.Success(context.Start.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
