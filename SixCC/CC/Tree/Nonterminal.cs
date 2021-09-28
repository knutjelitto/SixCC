namespace SixCC.CC.Tree
{
    internal class Nonterminal : Rule
    {
        public Nonterminal(Name name, Expression expression)
            : base(name, expression)
        {
        }

        public override string Head => "nonterminal";
    }
}
