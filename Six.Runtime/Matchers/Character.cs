namespace Six.Runtime.Matchers
{
    public sealed record Character(ImplementationCore Core, int Id, string Name, int CP) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            if (cursor.At == CP)
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
