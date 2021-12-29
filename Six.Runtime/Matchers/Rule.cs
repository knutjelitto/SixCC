namespace Six.Runtime.Matchers
{
    public abstract class Rule : Matcher
    {
        protected Rule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override bool IsTerminal => false;
    }
}
