namespace Six.Ceylon.Ast
{
    public sealed class InterfaceDeclaration : Node, Declaration
    {
        public InterfaceDeclaration(InterfaceHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public InterfaceHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class InterfaceHeader : Node
    {
        public InterfaceHeader(Annotations annotations, Keyword prefix, Name name, TypeParameters? parameters, InterfaceInheritance inheritance, TypeConstraints? constraints)
        {
            Annotations = annotations;
            Prefix = prefix;
            Name = name;
            Parameters = parameters;
            Inheritance = inheritance;
            Constraints = constraints;
        }

        public Annotations Annotations { get; }
        public Keyword Prefix { get; }
        public Name Name { get; }
        public TypeParameters? Parameters { get; }
        public InterfaceInheritance Inheritance { get; }
        public TypeConstraints? Constraints { get; }
    }

    public sealed class InterfaceInheritance : Node
    {
        public InterfaceInheritance(CaseTypes? caseTypes, SatisfiedTypes? satisfiedTypes)
        {
            CaseTypes = caseTypes;
            SatisfiedTypes = satisfiedTypes;
        }

        public CaseTypes? CaseTypes { get; }
        public SatisfiedTypes? SatisfiedTypes { get; }
    }
}
