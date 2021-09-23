namespace Six.Ceylon.Ast
{
    public sealed class ForStatement : Node, Statement
    {
        public ForStatement(ForIterator iterator, BlockDefinition block, Fallback? fallback)
        {
            Iterator = iterator;
            Block = block;
            Fallback = fallback;
        }

        public ForIterator Iterator { get; }
        public BlockDefinition Block { get; }
        public Fallback? Fallback { get; }
    }

    public sealed class ForIterator : Node
    {
        public ForIterator(Pattern pattern, Expression expression)
        {
            Pattern = pattern;
            Expression = expression;
        }

        public Pattern Pattern { get; }
        public Expression Expression { get; }
    }

    public sealed class Fallback : Node
    {
        public Fallback(BlockDefinition block)
        {
            Block = block;
        }

        public BlockDefinition Block { get; }
    }
}
