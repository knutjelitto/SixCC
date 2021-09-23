namespace Six.Ceylon.Ast
{
    public sealed class IfElseStatement : Node, Statement, Block
    {
        public IfElseStatement(IfPart ifPart, ElsePart? elsePart)
        {
            IfPart = ifPart;
            ElsePart = elsePart;
        }

        public IfPart IfPart { get; }
        public ElsePart? ElsePart { get; }
    }

    public sealed class IfPart : Node, Block
    {
        public IfPart(Conditions conditions, BlockDefinition block)
        {
            Conditions = conditions;
            Block = block;
        }

        public Conditions Conditions { get; }
        public BlockDefinition Block { get; }
    }

    public sealed class ElsePart : Node
    {
        public ElsePart(Block block)
        {
            Block = block;
        }

        public Block Block { get; }
    }
}
