namespace SixCC.CC.Tree
{
    internal class Complement : Family, Expression
    {
        public Complement(Expression expression)
            : base(expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
        public override string Head => "+";
    }
}
