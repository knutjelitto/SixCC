namespace SixCC.CC.Tree
{
    internal class OneOrMore : Family, Expression
    {
        public OneOrMore(Expression expression)
            : base(expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
        public override string Head => "+";
    }
}
