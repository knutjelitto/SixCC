namespace Six.Runtime.Matchers
{
    public sealed class IdentifierRule : DfaRule
    {
        public IdentifierRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            throw new InvalidOperationException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
