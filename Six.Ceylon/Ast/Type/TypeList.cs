namespace Six.Ceylon.Ast
{
    public record TypeList(IEnumerable<Type> Items) : ReadOnlyList<Type>(Items), Type;
}
