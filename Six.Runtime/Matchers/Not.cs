namespace Six.Runtime.Matchers
{
    public record Not(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Matchers[0].Match(new Context(context.Start,
                next =>
                {
                    context.Failure(context.Start);
                },
                next =>
                {
                    context.Success(context.Start);
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
