namespace Six.Ceylon.Ast
{
    public sealed class ExistsCondition : Node, Condition
    {
        public ExistsCondition(bool not, ConditionTestee testee)
        {
            Not = not;
            Testee = testee;
        }

        public bool Not { get; }
        public ConditionTestee Testee { get; }
    }
}
