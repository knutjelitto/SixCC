namespace Six.Runtime.Matchers
{
    public abstract record Token(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override bool IsTerminal => true;
    }
}
