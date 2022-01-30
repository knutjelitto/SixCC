namespace Six.Ceylon.Ast
{
    public class ConditionVariable
    {
        public ConditionVariable(Identifier name, Expr? value)
        {
            Name = name;
            Value = value;
        }

        public Identifier Name { get; }
        public Expr? Value { get; }
    }
}
