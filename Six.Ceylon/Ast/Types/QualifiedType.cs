using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class QualifiedType : Node, Type
    {
        public QualifiedType(PackageQualifier? packageQualifier, IEnumerable<NameWithArguments> names)
        {
            PackageQualifier = packageQualifier;
            Names = new NamesWithArguments(names);
        }

        public PackageQualifier? PackageQualifier { get; }
        public NamesWithArguments Names { get; }
    }
}
