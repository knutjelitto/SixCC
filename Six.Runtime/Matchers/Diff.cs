namespace Six.Runtime.Matchers
{
    public record Diff(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Assert(Matchers.Length == 2);

            var failed = false;

            Matchers[1].Match(new Context(context.Start,
                success =>
                {
                    if (!failed)
                    {
                        failed = true;
                        context.Failure(context.Start);

                    }
                },
                failure =>
                {
                    Matchers[0].Match(new Context(context.Start, context.Success, context.Failure));
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
