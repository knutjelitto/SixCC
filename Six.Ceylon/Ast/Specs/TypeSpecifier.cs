namespace Six.Ceylon.Ast
{
    /// <summary>
    /// '=>' type
    /// </summary>
    public sealed class TypeSpecifier : Node
    {
        public TypeSpecifier(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
