namespace Six.Ceylon.Ast
{
    public sealed class WhileStmt : Statement
    {
        public WhileStmt(ConditionList conditions, Block block)
        {
            Conditions = conditions;
            Block = block;
        }

        public ConditionList Conditions { get; }
        public Block Block { get; }
    }
}
