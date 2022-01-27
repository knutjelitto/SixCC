namespace Six.Ceylon.Ast
{
    public sealed class DeclarationList : ReadOnlyList<Declaration>
    {
        public DeclarationList(IEnumerable<Declaration> items) : base(items)
        {
        }
    }
}
