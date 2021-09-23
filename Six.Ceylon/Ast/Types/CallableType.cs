namespace Six.Ceylon.Ast
{
    public sealed class CallableType : Node, SugarType
    {
        public CallableType(Type primary, TypeList parameters)
        {
            Primary = primary;
            Parameters = parameters;
        }

        public Type Primary { get; }
        public TypeList Parameters { get; }
    }
}
