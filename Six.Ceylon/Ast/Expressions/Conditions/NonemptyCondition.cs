namespace Six.Ceylon.Ast
{
    public sealed class NonemptyCondition : Node, Condition
    {
        public NonemptyCondition(bool not, ConditionTestee testee)
        {
            Not = not;
            Testee = testee;
        }

        public bool Not { get; }
        public ConditionTestee Testee { get; }
    }
}
