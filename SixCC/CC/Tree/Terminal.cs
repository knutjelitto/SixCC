namespace SixCC.CC.Tree
{
    internal class Terminal : Rule
    {
        public Terminal(Name name, Expression expression)
            : base(name, expression)
        {
        }

        public override string Head => "terminal";
    }
}
