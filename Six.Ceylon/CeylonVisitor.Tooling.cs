using Six.Ceylon.Ast;
using Six.Runtime.Types;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        private T? Walk<T>(IRNode node)
            where T : class
        {
            Walk(node);

            return node.GetValue<T>();
        }

        private T Add<T>(RNode node, T declaration)
            where T : Declaration
        {
            node.Value = declaration;
            World.AddDeclaration(declaration);

            return declaration;
        }

        private IDisposable Use<T>(RNode node, T declaration)
            where T : Declaration
        {
            return World.Use(Add<T>(node, declaration));
        }

        private bool Exists(ROptional optional)
        {
            return optional.Children.Length == 1;
        }
    }
}
