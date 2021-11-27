namespace Six.Ast
{
    public sealed class Nonterminal : Symbol
    {
        internal Nonterminal(ILocation location, string name, Expression expression)
            : base(location, name, expression)
        {
            Assert(expression is Alternation);
            Assert(Alternation.Expressions.Count >= 1);
        }

        public Alternation Alternation => (Alternation)Expression;
        public IEnumerable<Sequence> Sequences => Alternation.Expressions.Cast<Sequence>();


        public override string ToString()
        {
            return $"non-terminal [{Name}]";
        }
    }
}
