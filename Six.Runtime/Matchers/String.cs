namespace Six.Runtime.Matchers
{
    public record String(ImplementationCore Core, int Id, string Name, string Text) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            if (cursor.Match(Text))
            {
                continuation.Success(cursor.Advance(Text.Length));
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
