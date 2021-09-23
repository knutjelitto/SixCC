namespace Six.Ceylon.Ast
{
    public class DefaultedType : Node, SugarType
    {
        public DefaultedType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
