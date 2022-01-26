namespace Six.Ceylon.Ast
{
    public class ConditionList : ReadOnlyList<Condition>
    {
        public ConditionList(IEnumerable<Condition> items) : base(items) {}
    }
}
