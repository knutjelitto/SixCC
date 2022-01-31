namespace Six.Ceylon.Ast
{
    public sealed record TypeArgumentList(IEnumerable<Type> Items) : TypeList(Items);
}
