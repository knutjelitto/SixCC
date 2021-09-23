namespace Six.Ceylon.Ast
{
    public sealed class ConstructorDeclaration : Node, Declaration
    {
        public ConstructorDeclaration(Annotations annotations, ConstructorHeader header, BlockDefinition definition)
        {
            Annotations = annotations;
            Header = header;
            Definition = definition;
        }

        public Annotations Annotations { get; }
        public ConstructorHeader Header { get; }
        public BlockDefinition Definition { get; }
    }

    public abstract class ConstructorHeader : Node
    {
        public ConstructorHeader(Name? name)
        {
            Name = name;
        }

        public Name? Name { get; }
    }

    public sealed class CallableConstructorHeader : ConstructorHeader
    {
        public CallableConstructorHeader(Name? name, Parameters parameters, ExtendedType? extendedType)
            : base(name)
        {
            Parameters = parameters;
            ExtendedType = extendedType;
        }

        public Parameters Parameters { get; }
        public ExtendedType? ExtendedType { get; }
    }

    public sealed class ValueConstructorHeader : ConstructorHeader
    {
        public ValueConstructorHeader(Name name, ExtendedType? extendedType)
            : base(name)
        {
            ExtendedType = extendedType;
        }

        public ExtendedType? ExtendedType { get; }
    }
}
