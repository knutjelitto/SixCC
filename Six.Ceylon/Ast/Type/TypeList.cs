namespace Six.Ceylon.Ast
{
    public class TypeList : ReadOnlyList<Type>
    {
        public TypeList(IEnumerable<Type> types) : base(types) { }
    }
}
