namespace Six.Ceylon.Ast
{
    public class TypeReference : IExpression
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
