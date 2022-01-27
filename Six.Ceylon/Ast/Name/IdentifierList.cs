namespace Six.Ceylon.Ast
{
    public class IdentifierList : ReadOnlyList<Identifier>
    {
        public IdentifierList(IEnumerable<Identifier> ids)
            : base(ids)
        {
        }
    }
}
