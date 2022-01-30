namespace Six.Ceylon.Ast
{
    public class TypeReference : Expr
    {
        public TypeReference(Identifier name, TypeArgumentList arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public TypeArgumentList Arguments { get; }
    }
}
