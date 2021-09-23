namespace Six.Ceylon.Ast
{
    public sealed class SetterDeclaration : Node, Declaration
    {
        public SetterDeclaration(SetterHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public SetterHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class SetterHeader : Node
    {
        public SetterHeader(Annotations annotations, Name name)
        {
            Annotations = annotations;
            Name = name;
        }

        public Annotations Annotations { get; }
        public Name Name { get; }
    }
}
