namespace Six.Ceylon.Ast
{
    public sealed class WhileStatement : Node, Statement
    {
        public WhileStatement(Conditions conditions, BlockDefinition block)
        {
            Conditions = conditions;
            Block = block;
        }

        public Conditions Conditions { get; }
        public BlockDefinition Block { get; }
    }
}
