using Six.Core;
using System;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class CodeUnitWalker
    {
        private readonly Stack<Container> current = new();

        private CodeUnitWalker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }

        public Container Into => current.Peek();

        public static void Walk(Module module, A.Unit.Code code)
        {
            new CodeUnitWalker(module).Walk(code);
        }

        private void Walk(A.Node? node)
        {
            if (node != null)
            {
                Visit((dynamic)node);
            }
        }

        private void WalkMany(IEnumerable<A.Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(node);
                }
            }
        }

        private IDisposable Push(Container container)
        {
            current.Push(container);

            return new Disposable(() => current.Pop());
        }


        private void Visit(A.Unit.Code code)
        {
            using (Push(Module.Open(code.Namespace)))
            {
                WalkMany(code.Declarations);
            }
        }

        private void Visit(A.Declaration node)
        {
            var content = new DeclarationScope(Into);

            Into.Add(Declaration.New(node, content));

            if (node is A.With.Body with)
            {
                using (Push(content))
                {
                    Walk(with.Body);
                }
            }
        }

        private void Visit(A.Statement node)
        {
            Into.Add(Statement.New(node));
        }

        private void Visit(A.Body.Block node)
        {
            WalkMany(node.Statelarations);
        }

        private void Visit(A.Body.Deferred node)
        {
        }

        private void Visit(A.Node node)
        {
            Assert(false);
        }
    }
}
