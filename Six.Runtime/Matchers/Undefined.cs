namespace Six.Runtime.Matchers
{
    public record Undefined(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            throw new NotImplementedException();
        }
    }
}
