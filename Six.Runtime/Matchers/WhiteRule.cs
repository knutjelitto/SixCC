namespace Six.Runtime.Matchers
{
    public record WhiteRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            if (Dfa != null)
            {
                //Console.WriteLine($"{context.Start}");
                Dfa.Match(new Context(context.Start,
                    success =>
                    {
                        context.Success(success);
                    },
                    failure =>
                    {
                        context.Failure(context.Start);
                    }));
            }
            else
            {
                Matchers[0].Match(context);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
