namespace Six.Runtime.Matchers
{
    public sealed record IdentifierRule(ImplementationCore Core, int Id, string Name)
        : DfaRule(Core, Id, Name)
    {
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
