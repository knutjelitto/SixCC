namespace Six.Ceylon.Ast
{
    public sealed class CountedTupleType : Node, SugarType
    {
        public CountedTupleType(Type type, Integer integer)
        {
            Type = type;
            Integer = integer;
        }

        public Type Type { get; }
        public Integer Integer { get; }
    }
}
