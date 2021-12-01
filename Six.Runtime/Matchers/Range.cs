namespace Six.Runtime.Matchers
{
    public record Range(ImplementationCore Core, int Id, string Name, int CP1, int CP2) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            var at = cursor.At;

            if (CP1 <= at && at <= CP2)
            {
                continuation.Success(cursor.Advance(1));
            }
            else
            {
                continuation.Fail(cursor);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
