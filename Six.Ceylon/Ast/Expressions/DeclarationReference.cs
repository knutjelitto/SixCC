namespace Six.Ceylon.Ast
{
    public sealed class DeclarationReference : Node, Expression
    {
        public DeclarationReference(ReferenceKeyword keyword, ReferenceName? name)
        {
            Keyword = keyword;
            Name = name;
        }

        public ReferenceKeyword Keyword { get; }
        public ReferenceName? Name { get; }
    }

    public sealed class ReferenceKeyword : Node
    {
        public ReferenceKeyword(Terminal keyword)
        {
            Keyword = keyword;
        }

        public Terminal Keyword { get; }
    }

    public sealed class ReferenceName : Node
    {
        public ReferenceName(PackageQualifier? qualifier, DottedName name)
        {
            Qualifier = qualifier;
            Name = name;
        }

        public PackageQualifier? Qualifier { get; }
        public DottedName Name { get; }
    }
}
