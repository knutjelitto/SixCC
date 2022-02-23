using Six.Core;
using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class DeclarationWalker
    {
        private DeclarationWalker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        public static void Walk(Module module, A.Unit.Code code)
        {
            new DeclarationWalker(module).CodeUnit(code);
        }

        private void CodeUnit(A.Unit.Code code)
        {
            var @namespace = Module.Open(code.Namespace);

            WalkMany(@namespace, code.Declarations);
        }

        private void WalkMany(Scope scope, IEnumerable<A.Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(scope, node);
                }
            }
        }

        private void Walk(Scope scope, A.Node? node)
        {
            if (node != null)
            {
                try
                {
                    Declare((dynamic)scope, (dynamic)node);
                }
                catch
                {
                    Assert(false);
                }
            }
        }

        private void Declare(Scope container, A.Node node)
        {
            Assert(false);
        }

        private void Declare(Scope container, A.Decl.Classy node)
        {
            var scope = new ClassyScope(container);
            container.Add(new Declaration(scope, node));
            if (node is A.With.Body body)
            {
                Walk(scope.Content, body.Body);
            }
        }

        private void Declare(Scope container, A.Decl.Funcy node)
        {
            var scope = new FuncyScope(container);
            container.Add(new Declaration(scope, node));
            if (node is A.With.Body body)
            {
                Walk(scope.Content, body.Body);
            }
        }

        private void Declare(Scope container, A.Decl.Alias node)
        {
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.Decl.Attribute node)
        {
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.Decl.Var node)
        {
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.Decl.Let node)
        {
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(BlockScope container, A.Body.Block node)
        {
            WalkMany(container, node.Statelarations);
        }

        private void Declare(BlockScope container, A.Body.Builtin node)
        {
        }

        private void Declare(BlockScope container, A.Stmt node)
        {
            container.Add(new Statement(container, node));
        }
    }
}
