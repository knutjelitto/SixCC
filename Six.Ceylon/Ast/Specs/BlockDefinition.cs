namespace Six.Ceylon.Ast
{
    public sealed class BlockDefinition : Node, Block, Definition
    {
        public BlockDefinition(Imports imports, Members members)
        {
            Imports = imports;
            Members = members;
        }

        public Imports Imports { get; }
        public Members Members { get; }
    }
}
