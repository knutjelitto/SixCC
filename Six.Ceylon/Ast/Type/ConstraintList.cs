namespace Six.Ceylon.Ast
{
    public sealed class ConstraintList : ReadOnlyList<IExpression>
    {
        public ConstraintList(IEnumerable<IExpression> items) : base(items) { }
    }
}
