namespace Six.Runtime.Matchers
{
    public record Token(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override void Match(Cursor current, Continuation continuation)
        {
            if (!Core.__InToken)
            {
                Core.__InToken = true;
                Core.__CollectWhitespace(current, new Continuation(current,
                    succ => Continue(succ),
                    fail => Continue(fail)));
                Core.__InToken = false;

                void Continue(Cursor cursor)
                {
                    MatchCore(cursor, new Continuation(cursor,
                        succ =>
                        {
                            Core.__InToken = false;
                            continuation.Success(succ);
                            Core.__InToken = true;
                        },
                        fail =>
                        {
                            Core.__InToken = false;
                            continuation.Fail(fail);
                            Core.__InToken = true;
                        }));
                }

            }
            else
            {
                MatchCore(current, continuation);
            }
        }

        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            Matchers[0].Match(cursor, continuation);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
