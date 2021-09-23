namespace Six.Ceylon.Ast
{
    public sealed class TupleType : Node, SugarType
    {
        public TupleType(TypeList types)
        {
            Types = types;
        }

        public TypeList Types { get; }
    }
}
