namespace Six.Ceylon.Ast
{
    public sealed class DynamicStatement : Node, Statement
    {
        public DynamicStatement(BlockDefinition block)
        {
            Block = block;
        }

        public BlockDefinition Block { get; }
    }
}
