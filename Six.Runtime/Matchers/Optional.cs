namespace Six.Runtime.Matchers
{
    public record Optional(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continuation)
        {
            Matchers[0].Match(current, new Continuation(current,
                success =>
                {
                    // bail out nullables
                    if (success > current)
                    {
                        continuation.Success(success);
                    }
                },
                failure =>
                {
                    // ignore: optional can't fail
                }));

            continuation.Success(current);
        }
    }
}
