namespace Six.Ceylon.Ast
{
    public class ConditionVariable
    {
        public ConditionVariable(Identifier name, IExpression? value)
        {
            Name = name;
            Value = value;
        }

        public Identifier Name { get; }
        public IExpression? Value { get; }
    }
}
