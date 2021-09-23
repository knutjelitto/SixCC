namespace Six.Ceylon.Ast
{
    public sealed class ValueDeclaration : Node, Declaration
    {
        public ValueDeclaration(ValueHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public ValueHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class ValueHeader : Node
    {
        public ValueHeader(Annotations annotations, Type prefix, Name name)
        {
            Annotations = annotations;
            Prefix = prefix;
            Name = name;
        }

        public Annotations Annotations { get; }
        public Type Prefix { get; }
        public Name Name { get; }
    }
}
