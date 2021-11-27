namespace Six.Runtime
{
    public sealed record Fragment(IRunImplementation Context, int Id, string Descriptor)
        : Symbol(Context, Id, Descriptor)
    {
        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            throw new NotImplementedException();
        }
    }
}