using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class ImportDeclaration : Node, Declaration
    {
        public ImportDeclaration(DottedName name, ImportElements elements)
        {
            Name = name;
            Elements = elements;
        }

        public DottedName Name { get; }
        public ImportElements Elements { get; }
    }

    public sealed class ImportElement : Node
    {
        public ImportElement(ImportAlias? alias, Name name, ImportElements? elements)
        {
            Alias = alias;
            Name = name;
            Elements = elements;
        }

        public ImportAlias? Alias { get; }
        public Name Name { get; }
        public ImportElements? Elements { get; }
    }

    public sealed class ImportAlias : Node
    {
        public ImportAlias(Name name)
        {
            Name = name;
        }

        public Name Name { get; }
    }

    public sealed class ImportElementList : NodeList<ImportElement>
    {
        public ImportElementList(IEnumerable<ImportElement> items) : base(items)
        {
        }
    }

    public sealed class ImportElements : Node
    {
        public ImportElements(ImportElementList? elements, ImportWildcard? wildcard)
        {
            Elements = elements ?? new ImportElementList(Enumerable.Empty<ImportElement>());
            Wildcard = wildcard;
        }

        public ImportElementList Elements { get; }
        public ImportWildcard? Wildcard { get; }
    }

    public sealed class ImportWildcard : Node
    {
        public ImportWildcard()
        {
        }
    }
}
