namespace Six.Runtime.Matchers
{
    public abstract record Structural(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override bool IsTerminal => false;
    }
}
