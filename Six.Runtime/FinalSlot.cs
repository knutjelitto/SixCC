namespace Six.Runtime
{
    public record FinalSlot(IRunImplementation Context, int Id)
        : Slot(Context, Id)
    {
        public override void Match(Cursor cursor, Continuation continueWith)
        {
            continueWith.Invoke(cursor);
        }
    }
}
