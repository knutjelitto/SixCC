namespace Six.Ceylon.Ast
{
    public sealed record CatchBlockList(IEnumerable<CatchBlock> blocks) : ReadOnlyList<CatchBlock>(blocks.ToList());
}
