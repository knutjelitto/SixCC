using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TryStatement : Node, Statement
    {
        public TryStatement(TryBlock tryBlock, CatchBlocks catchBlocks, FinallyBlock? finallyBlock)
        {
            Try = tryBlock;
            Catches = catchBlocks;
            Finally = finallyBlock;
        }

        public TryBlock Try { get; }
        public CatchBlocks Catches { get; }
        public FinallyBlock? Finally { get; }
    }

    public sealed class TryBlock : Node
    {
        public TryBlock(Resources? resources, BlockDefinition block)
        {
            Resources = resources;
            Block = block;
        }

        public Resources? Resources { get; }
        public BlockDefinition Block { get; }
    }

    public sealed class Resources : NodeList<Resource>
    {
        public Resources(IEnumerable<Resource> items) : base(items)
        {
        }
    }

    public interface Resource : INode
    {
    }

    public sealed class CatchBlocks : NodeList<CatchBlock>
    {
        public CatchBlocks(IEnumerable<CatchBlock> items) : base(items)
        {
        }
    }

    public sealed class CatchBlock : Node
    {
        public CatchBlock(Variable variable, BlockDefinition block)
        {
            Variable = variable;
            Block = block;
        }

        public Variable Variable { get; }
        public BlockDefinition Block { get; }
    }

    public sealed class FinallyBlock : Node
    {
        public FinallyBlock(BlockDefinition block)
        {
            Block = block;
        }

        public BlockDefinition Block { get; }
    }
}
