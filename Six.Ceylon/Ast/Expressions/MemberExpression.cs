namespace Six.Ceylon.Ast
{
    public sealed class MemberExpression : Node, Expression
    {
        public MemberExpression(Expression expression, MemberSelector selector)
        {
            Expression = expression;
            Selector = selector;
        }

        public Expression Expression { get; }
        public MemberSelector Selector { get; }
    }

    public sealed class MemberSelector : Node
    {
        public MemberSelector(Terminal op, NameWithArguments nameWithArguments)
        {
            Op = op;
            NameWithArguments = nameWithArguments;
        }

        public Terminal Op { get; }
        public NameWithArguments NameWithArguments { get; }
    }

}
