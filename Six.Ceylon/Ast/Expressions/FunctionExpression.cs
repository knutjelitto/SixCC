namespace Six.Ceylon.Ast
{
    public sealed class FunctionExpression : Node, Expression
    {
        public FunctionExpression(Terminal? prefix, ParametersList parameters, Block block)
        {
            Prefix = prefix;
            Parameters = parameters;
            Block = block;
        }

        public Terminal? Prefix { get; }
        public ParametersList Parameters { get; }
        public Block Block { get; }
    }
}
