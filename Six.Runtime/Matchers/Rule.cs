namespace Six.Runtime.Matchers
{
    public abstract record Rule(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override void Match(Context context)
        {
            Assert(context.Matcher == this);

            if (!Continuations.TryGetValue(context.Start, out var continuations))
            {
                continuations = new List<Context>();
                Continuations.Add(context.Start, continuations);
                Successes.Add(context.Start, new HashSet<Cursor>());
                continuations.Add(context);

                MatchCore(
                    context.Start,
                    success =>
                    {
                        Successes[context.Start].Add(success);
                        foreach (var continuation in Continuations[context.Start])
                        {
                            continuation.Success(success);
                        }
                    });
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

        public override string ToString()
        {
            return Name;
        }
    }
}
