namespace Six.Ceylon.Ast
{
    public abstract class Meta : Node, Expression
    {
    }

    public sealed class TypeMeta : Meta
    {
        public TypeMeta(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
