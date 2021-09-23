namespace Six.Ceylon.Ast
{
    public sealed class SpreadType : Node, SugarType
    {
        public SpreadType(Type type) // *type
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
