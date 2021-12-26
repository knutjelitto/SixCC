namespace Six.Runtime.Matchers
{
    public sealed record WhiteRule(ImplementationCore Core, int Id, string Name)
        : DfaRule(Core, Id, Name)
    {
        public Dictionary<Cursor, Cursor> Whites = new();

        public override void MatchCore(Context context)
        {
            throw new InvalidOperationException();
        }

        public override void Reset()
        {
            base.Reset();
            Whites.Clear();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
