namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name)
    {
        public Matcher[] Matchers = Array.Empty<Matcher>();

        protected abstract void MatchCore(Cursor cursor, Continuation continuation);

        public virtual void Match(Cursor cursor, Continuation continuation)
        {
            MatchCore(cursor, continuation);
        }

        public void Set(params Matcher[] matchers)
        {
            Matchers = matchers;
        }

        protected void CollectWhitespace(Cursor current, Continuation continuation)
        {
            if (Core.__InToken)
            {
                continuation.Success(current);
            }
            else
            {
                Core.__Whitespace.Match(current, new Continuation(current,
                    succ =>
                    {
                        continuation.Success(succ);
                    },
                    fail =>
                    {
                        continuation.Fail(fail);
                    }));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
