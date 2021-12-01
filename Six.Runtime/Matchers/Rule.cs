namespace Six.Runtime.Matchers
{
    public record Rule(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected readonly Dictionary<Cursor, List<Continuation>> Continuations = new();
        protected readonly Dictionary<Cursor, HashSet<Cursor>> Successes = new();
        protected readonly Dictionary<Cursor, HashSet<Cursor>> Failures = new();

        public override void Match(Cursor current, Continuation continueWith)
        {
            if (Name == "rule")
            {
                Assert(true);
            }
            Assert(Matchers.Length == 1);
            var first = false;

            if (!Continuations.TryGetValue(current, out var continuations))
            {
                continuations = new List<Continuation>();
                Continuations.Add(current, continuations);
                Successes.Add(current, new HashSet<Cursor>());
                Failures.Add(current, new HashSet<Cursor>());
                first = true;
            }
            continuations.Add(continueWith);

            if (!first)
            {
                foreach (var succ in Successes[current])
                {
                    continueWith.Success(succ);
                }

                foreach (var fail in Failures[current])
                {
                    continueWith.Fail(fail);
                }
            }
            else
            {
                MatchCore(current, new Continuation(current,
                    succ =>
                    {
                        Successes[current].Add(succ);
                        foreach (var continuation in Continuations[current])
                        {
                            continuation.Success(succ);
                        }
                    },
                    fail =>
                    {
                        Failures[current].Add(fail);
                        foreach (var continuation in Continuations[current])
                        {
                            continuation.Fail(fail);
                        }
                    }));
            }
        }

        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            Matchers[0].Match(cursor, continueWith);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
