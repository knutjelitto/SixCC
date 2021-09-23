using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Imports : NodeList<ImportDeclaration>
    {
        public Imports(IEnumerable<ImportDeclaration> items) : base(items)
        {
        }
    }
}
