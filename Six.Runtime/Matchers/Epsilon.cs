namespace Six.Runtime.Matchers
{
    public record Epsilon(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            continuation.Success(cursor);
        }
    }
}
