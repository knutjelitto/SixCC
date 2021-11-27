namespace Six.Runtime
{
    public record IntermediateSlot(IRunImplementation Context, int Id, int SymbolId, int NextSlotId)
        : Slot(Context, Id)
    {
        public override void Match(Cursor cursor, Continuation continueWith)
        {
            var symbol = Context.Symbols[SymbolId];

            symbol.Match(cursor, new Continuation(next =>
            {
                var nextSlot = Context.Slots[NextSlotId];
                nextSlot.Match(next, continueWith);
            }));
        }
    }
}
