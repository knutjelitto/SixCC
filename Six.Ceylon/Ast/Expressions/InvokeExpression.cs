namespace Six.Ceylon.Ast
{
    public sealed class InvokeExpression : Node, Expression
    {
        public InvokeExpression(Expression primary, Arguments arguments)
        {
            Primary = primary;
            Arguments = arguments;
        }

        public Expression Primary { get; }
        public Arguments Arguments { get; }
    }
}
