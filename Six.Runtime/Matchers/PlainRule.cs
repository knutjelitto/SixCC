namespace Six.Runtime.Matchers
{
    public record PlainRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Matchers[0].Match(context.Start, context.Success);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
