namespace Six.Ceylon.Ast
{
    /// <summary>
    /// 'abstracts' primaryType
    /// </summary>
    public sealed class AbstractedType : Node, Type
    {
        public AbstractedType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
