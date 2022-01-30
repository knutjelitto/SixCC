using Six.Ceylon.Ast;
using Six.Runtime.Types;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        private T Walk<T>(IRNode node)
            where T : class
        {
            Walk(node);

            Assert(node.Value != null);

            var value = node.GetValue<T>();

            Assert(value != null && typeof(T).IsAssignableFrom(value.GetType()));

            return value;
        }

        private IEnumerable<T> WalkMany<T>(IRNode node)
            where T : class
        {
            return node.Children.Select(child => Walk<T>(child));
        }

        private T? Walk<T>(ROptional node)
            where T : class
        {
            Walk(node);

            var value = node.GetValue<T>();

            Assert(value == null || typeof(T).IsAssignableFrom(value.GetType()));

            return value;
        }

        private T Add<T>(RNode node, T declaration)
            where T : Stmt
        {
            node.Value = declaration;
            World.AddDeclaration(declaration);

            return declaration;
        }

        private IDisposable Use<T>(RNode node, T declaration)
            where T : Stmt, IBodyOwner
        {
            return World.Use(Add<T>(node, declaration));
        }

        private bool Exists(ROptional optional)
        {
            return optional.Children.Length == 1;
        }
    }
}
