namespace Six.Ceylon.Ast
{
    public sealed class AliasDeclaration : Node, Declaration
    {
        public AliasDeclaration(AliasHeader header, TypeDefinition definition)
        {
            Header = header;
            Definition = definition;
        }

        public AliasHeader Header { get; }
        public TypeDefinition Definition { get; }
    }

    public sealed class AliasHeader : Node
    {
        public AliasHeader(Annotations annotations, Name name, TypeParameters? parameters, TypeConstraints? constraints)
        {
            Annotations = annotations;
            Name = name;
            Parameters = parameters;
            Constraints = constraints;
        }

        public Annotations Annotations { get; }
        public Name Name { get; }
        public TypeParameters? Parameters { get; }
        public TypeConstraints? Constraints { get; }
    }
}
