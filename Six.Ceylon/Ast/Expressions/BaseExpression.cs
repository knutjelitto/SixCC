namespace Six.Ceylon.Ast
{
    public sealed class BaseExpression : Node, Expression
    {
        public BaseExpression(PackageQualifier? qualifier, NameWithArguments nameWithArguments)
        {
            Qualifier = qualifier;
            NameWithArguments = nameWithArguments;
        }

        public PackageQualifier? Qualifier { get; }
        public NameWithArguments NameWithArguments { get; }
    }
}
