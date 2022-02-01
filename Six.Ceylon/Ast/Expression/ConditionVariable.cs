namespace Six.Ceylon.Ast
{
    public class ConditionVariable : AstNode
    {
        public ConditionVariable(Identifier name, Expr.Specifier.Value? value)
        {
            Name = name;
            Value = value;
        }

        public Identifier Name { get; }
        public Expr.Specifier.Value? Value { get; }
    }
}
