namespace Six.Runtime.Matchers
{
    public record Rule(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected readonly Dictionary<Cursor, List<Context>> Continuations = new();
        protected readonly Dictionary<Cursor, HashSet<Cursor>> Successes = new();

        public override void Match(Context context)
        {
            Assert(Dfa == null);
            var first = false;

            if (!Continuations.TryGetValue(context.Start, out var continuations))
            {
                continuations = new List<Context>();
                Continuations.Add(context.Start, continuations);
                Successes.Add(context.Start, new HashSet<Cursor>());
                first = true;
            }
            continuations.Add(context);

            if (!first)
            {
                foreach (var succ in Successes[context.Start])
                {
                    context.Success(succ);
                }
            }
            else
            {
                MatchCore(new Context(context.Start,
                    succ =>
                    {
                        Successes[context.Start].Add(succ);
                        foreach (var continuation in Continuations[context.Start])
                        {
                            continuation.Success(succ);
                        }
                    }));
            }
        }

        protected override void MatchCore(Context context)
        {
            if (Dfa != null)
            {
                Core.__MatchToken(context, Dfa);
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
