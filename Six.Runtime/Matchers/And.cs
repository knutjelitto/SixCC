namespace Six.Runtime.Matchers
{
    public record And(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continuation)
        {
            Matchers[0].Match(current, new Continuation(current, 
                next =>
                {
                    continuation.Success(current);
                },
                next =>
                {
                    continuation.Fail(current);
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
