namespace Six.Runtime
{
    public record Production(IRunImplementation Context, int Id, int FirstSlotId)
    {
        public void Match(Cursor cursor, Continuation continueWith)
        {
            Context.Slots[FirstSlotId].Match(cursor, continueWith);
        }
    }
}
