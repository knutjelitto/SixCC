namespace Six.Ceylon.Ast
{
    public class ConditionList : ReadOnlyList<IExpression>
    {
        public ConditionList(IEnumerable<IExpression> items) : base(items) {}
    }
}
