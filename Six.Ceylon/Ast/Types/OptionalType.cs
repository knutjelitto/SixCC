namespace Six.Ceylon.Ast
{
    public sealed class OptionalType : Node, SugarType
    {
        public OptionalType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
