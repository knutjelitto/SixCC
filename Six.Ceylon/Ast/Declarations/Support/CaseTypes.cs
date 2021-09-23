using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class CaseTypes : NodeList<OfCaseItem>
    {
        public CaseTypes(IEnumerable<OfCaseItem> items) : base(items)
        {
        }
    }

    public abstract class OfCaseItem : Node
    {
    }

    public sealed class CaseType : OfCaseItem
    {
        public CaseType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }

    public sealed class CaseValue : OfCaseItem
    {
        public CaseValue(PackageQualifier? qualifier, Name name)
        {
            Qualifier = qualifier;
            Name = name;
        }

        public PackageQualifier? Qualifier { get; }
        public Name Name { get; }
    }
}
