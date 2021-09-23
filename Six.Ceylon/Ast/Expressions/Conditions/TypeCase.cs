namespace Six.Ceylon.Ast
{
    public sealed class TypeCase : Node, ConditionForCase
    {
        public TypeCase(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
