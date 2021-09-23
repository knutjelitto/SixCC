namespace Six.Ceylon.Ast
{
    public sealed class VariableWithValue : Node, Switchable, Resource
    {
        public VariableWithValue(Variable variable, ValueSpecifier value)
        {
            Variable = variable;
            Value = value;
        }

        public Variable Variable { get; }
        public ValueSpecifier Value { get; }
    }
}
