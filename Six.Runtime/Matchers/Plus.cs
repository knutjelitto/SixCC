namespace Six.Runtime.Matchers
{
    public record Plus(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continuation)
        {
            Matchers[0].Match(current, new Continuation(current, Success, FirstFailure));

            void Success(Cursor succ)
            {
                continuation.Success(succ);
                Matchers[0].Match(succ, new Continuation(succ, Success, NextFailure));
            }

            void FirstFailure(Cursor fail)
            {
                continuation.Fail(fail);
            }

            void NextFailure(Cursor fail)
            {
            }
        }
    }
}
