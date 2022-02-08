using Six.Core;
using Six.Sax.Ast;
using System;

namespace Six.Sax.Sema
{
    public class CodeUnitWalker
    {
        private Stack<IScope> scopes = new Stack<IScope>();

        private CodeUnitWalker(Global global, NamespaceScope scope)
        {
            Global = global;

            scopes.Push(scope);
        }

        public Global Global { get; }

        public IScope Into => scopes.Peek();

        public static void Walk(Global global, Unit.Code code)
        {
            var scope = global.Open(code.Namespace.Names.Select(n => n.Text));

            var walker = new CodeUnitWalker(global, scope);

            walker.Walk(code);
        }

        private void Walk(Unit.Code code)
        {
            if (code.Skip)
            {
                return;
            }

            foreach (var declaration in code.Declarations)
            {
                Walk(declaration);
            }
        }

        private void Walk(Node? node)
        {
            if (node != null)
            {
                Visit((dynamic)node);
            }
        }

        private void WalkMany(IEnumerable<Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(node);
                }
            }
        }

        private IDisposable Push(IScope scope)
        {
            scopes.Push(scope);

            return new Disposable(() => scopes.Pop());
        }

        private void Visit(Node node)
        {
            Assert(false);
        }

        private void Visit(Declaration.Entity.Impl node)
        {
            Into.Declare(node);

            using (Push(new DeclarationScope(Into)))
            {
                WalkMany(node.Generics);
                WalkMany(node.Parameters);
            }
        }

        private void Visit(Declaration.Entity.Class node)
        {
            Into.Declare(node);
        }

        private void Visit(Parameter node)
        {
            Into.Declare(node);
            Into.ToResolve(node.Type);
        }

        private void Visit(Generic.Parameter node)
        {
            Into.Declare(node);
        }
    }
}
