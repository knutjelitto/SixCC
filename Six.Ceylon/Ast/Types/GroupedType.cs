namespace Six.Ceylon.Ast
{
    public sealed class GroupedType : Node, SugarType
    {
        public GroupedType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
