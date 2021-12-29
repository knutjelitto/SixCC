namespace Six.Runtime.Matchers
{
    public abstract class Structural : Matcher
    {
        protected Structural(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override bool IsTerminal => false;
    }
}
