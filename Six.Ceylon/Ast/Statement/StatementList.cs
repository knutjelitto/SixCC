namespace Six.Ceylon.Ast
{
    public class StatementList : ReadOnlyList<Statement>
    {
        public StatementList(IEnumerable<Statement> items) : base(items)
        {
        }
    }
}
