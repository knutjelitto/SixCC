using Six.Ceylon.Ast;
using Six.Runtime.Types;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        private T Add<T>(RNode node, T declaration)
            where T : Declaration
        {
            node.Value = declaration;
            World.AddDeclaration(declaration);

            return declaration;
        }
    }
}
