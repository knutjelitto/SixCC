namespace Six.Runtime.Matchers
{
    public abstract class Token : Matcher
    {
        protected Token(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override bool IsTerminal => true;
    }
}
