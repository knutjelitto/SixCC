namespace Six.Runtime.Matchers
{
    public abstract record Rule(ImplementationCore Core, int Id, string Name)
        : Matcher(Core, Id, Name)
    {
        public override bool IsTerminal => false;
    }
}
