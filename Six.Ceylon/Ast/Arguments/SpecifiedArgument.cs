namespace Six.Ceylon.Ast
{
    public sealed class SpecifiedArgument : Node, NamedArgument
    {
        public SpecifiedArgument(Specification specification)
        {
            Specification = specification;
        }

        public Specification Specification { get; }
    }

    public sealed class Specification : Node, Member
    {
        public Specification(MemberReference reference, Definition definition)
        {
            Reference = reference;
            Definition = definition;
        }

        public MemberReference Reference { get; }
        public Definition Definition { get; }
    }

    public sealed class MemberReference : Node
    {
        public MemberReference(ThisQualifier? qualifier, Name name, ParametersList parameters)
        {
            Qualifier = qualifier;
            Name = name;
            Parameters = parameters;
        }

        public ThisQualifier? Qualifier { get; }
        public Name Name { get; }
        public ParametersList Parameters { get; }
    }
}
