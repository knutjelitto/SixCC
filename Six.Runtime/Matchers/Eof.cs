namespace Six.Runtime.Matchers
{
    public record Eof(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            if (cursor.At == -1)
            {
                continuation.Fail(cursor);
            }
            else
            {
                continuation.Success(cursor.Advance(1));
            }
        }
    }
}
