namespace Six.Ceylon.Ast
{
    public sealed class CaseCondition : Node
    {
        public CaseCondition(ConditionForCase condition)
        {
            Condition = condition;
        }

        public ConditionForCase Condition { get; }
    }
}
