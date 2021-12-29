namespace Six.Runtime.Matchers
{
    public sealed class WhiteRule : DfaRule
    {
        public Dictionary<Cursor, Cursor> Whites = new();

        public WhiteRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

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
