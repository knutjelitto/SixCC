namespace Six.Ceylon.Ast
{
    public sealed class TypeExpression : Node, Expression
    {
        public TypeExpression(Terminal op, Expression expression, Type type)
        {
            Op = op;
            Expression = expression;
            Type = type;
        }

        public Terminal Op { get; }
        public Expression Expression { get; }
        public Type Type { get; }
    }
}
