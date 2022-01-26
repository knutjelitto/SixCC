namespace Six.Ceylon.Ast
{
    public sealed class ConstraintList : ReadOnlyList<Expression>
    {
        public ConstraintList(IEnumerable<Expression> items) : base(items) { }
    }
}
