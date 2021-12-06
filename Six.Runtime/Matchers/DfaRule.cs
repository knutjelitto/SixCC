namespace Six.Runtime.Matchers
{
    public record DfaRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        public override void Match(Context context)
        {
            Assert(Dfa != null);
            
            if (!Continuations.TryGetValue(context.Start, out var continuations))
            {
                continuations = new List<Context>();
                Continuations.Add(context.Start, continuations);
                Successes.Add(context.Start, new HashSet<Cursor>());
                continuations.Add(context);

                MatchCore(new Context(context.Start,
                    success =>
                    {
                        Successes[context.Start].Add(success);
                        foreach (var continuation in Continuations[context.Start])
                        {
                            continuation.Success(success);
                        }
                    }));
            }
            else
            {
                continuations.Add(context);

                foreach (var succ in Successes[context.Start])
                {
                    context.Success(succ);
                }
            }
        }

        protected override void MatchCore(Context context)
        {
            Assert(Dfa != null);

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
