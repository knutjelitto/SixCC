﻿namespace Six.Runtime.Matchers
{
    public record Not(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continuation)
        {
            Matchers[0].Match(current, new Continuation(current,
                next =>
                {
                    continuation.Fail(current);
                },
                next =>
                {
                    continuation.Success(current);
                }));
        }
    }
}
