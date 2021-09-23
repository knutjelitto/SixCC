namespace Six.Ceylon.Ast
{
    public sealed class IsCondition : Node, Condition
    {
        public IsCondition(bool not, TypedVariable variable, ValueSpecifier? value)
        {
            Not = not;
            Variable = variable;
            Value = value;
        }

        public bool Not { get; }
        public TypedVariable Variable { get; }
        public ValueSpecifier? Value { get; }
    }

    public sealed class TypedVariable : Node
    {
        public TypedVariable(Type type, Name name)
        {
            Type = type;
            Name = name;
        }

        public Type? Type { get; }
        public Name Name { get; }
    }
}
