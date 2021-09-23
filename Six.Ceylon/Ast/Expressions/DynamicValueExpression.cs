namespace Six.Ceylon.Ast
{
    public sealed class DynamicValueExpression : Node, Expression
    {
        public DynamicValueExpression(NamedArgumentList named, ArgumentList positional)
        {
            Named = named;
            Positional = positional;
        }

        public NamedArgumentList Named { get; }
        public ArgumentList Positional { get; }
    }
}
