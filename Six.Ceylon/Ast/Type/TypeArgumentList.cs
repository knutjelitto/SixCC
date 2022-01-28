namespace Six.Ceylon.Ast
{
    public sealed record TypeArgumentList(IEnumerable<Typo> Items) : TypeList(Items);
}
