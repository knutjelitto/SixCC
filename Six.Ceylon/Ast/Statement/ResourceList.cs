namespace Six.Ceylon.Ast
{
    public sealed record ResourceList(IEnumerable<Resource> Resources)
        : ReadOnlyList<Resource>(Resources);
}
