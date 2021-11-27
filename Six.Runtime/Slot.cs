namespace Six.Runtime
{
    public abstract record Slot(IRunImplementation Context, int Id)
    {
        public abstract void Match(Cursor cursor, Continuation continueWith);
    }
}
