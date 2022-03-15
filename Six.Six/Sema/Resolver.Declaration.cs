using Six.Core;
using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        private void WalkDeclarations(Scope scope, IEnumerable<A.Decl>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    WalkDeclaration(scope, node);
                }
            }
        }

        private void WalkDeclaration(Scope scope, A.Decl node)
        {
            Declare((dynamic)scope, (dynamic)node);
        }

        private void Declare(Scope container, A.Node node)
        {
            Assert(false);
        }

        private void DeclareClassyBody(Decl.Classy decl, A.Decl.Classy node)
        {
            using (UseMemby(decl))
            {
                WalkBody(decl.Scope.Block, node.Body);
            }
        }

        //**

        private void Declare(Scope parent, A.Decl.Class node)
        {
            var decl = new Decl.Class(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Scope parent, A.Decl.Interface node)
        {
            var decl = new Decl.Interface(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Scope parent, A.Decl.Object node)
        {
            var decl = new Decl.Object(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void DeclareFunction(Decl.Function decl, A.Decl.Function node)
        {
            var method = false;
            Decl.Classy? klass = null;

            if (InMemby)
            {
                method = InClassy;
                klass = CurrentMemby as Decl.Classy;

                CurrentMemby.Members.Add(decl);
            }
            else
            {
                Assert(true);
            }
            using (UseMemby(decl))
            {
                if (method)
                {
                    Assert(klass != null);
                    DeclareSelf(decl, klass);
                }
                WalkDeclarations(decl.Scope, node.Parameters);
                WalkBody(decl.Scope.Block, node.Body);
            }
        }

        private void Declare(Scope parent, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            DeclareFunction(new Decl.Function(parent, node, InfixName(node)), node);
        }

        private void Declare(Scope parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            DeclareFunction(new Decl.Function(parent, node, PrefixName(node)), node);
        }

        private void Declare(Scope parent, A.Decl.Function node)
        {
            Assert(node.Parameters.Count >= 0);

            DeclareFunction(new Decl.Function(parent, node, null), node);
        }

        private void DeclareSelf(Decl.Funcy funcy, Decl.Classy classy)
        {
            var self = new Decl.SelfParameter(funcy.Scope, new Type.Reference(classy), 0);
            funcy.Scope.Declare(self, Names.Core.SelfValue);
            funcy.Parameters.Add(self);
        }

        private void Declare(Scope parent, A.Decl.Constructor node)
        {
            Assert(InClass);

            var decl = new Decl.Constructor(parent, (Decl.Class)CurrentMemby, node);

            var classy = CurrentMemby as Decl.Class;
            Assert(classy != null);

            CurrentMemby.Members.Add(decl);

            using (UseMemby(decl))
            {

                DeclareSelf(decl, classy);
                WalkDeclarations(decl.Scope, node.Parameters);
                WalkBody(decl.Scope.Block, node.Body);
            }
        }

        private void Declare(Scope parent, A.Decl.Alias node)
        {
            var decl = new Decl.Alias(parent, node);
        }

        private void Declare(BlockScope parent, A.Decl.Attribute node)
        {
            var decl = parent.Declare(new Decl.Attribute(parent, node));
            CurrentMemby.Members.Add(decl);

            var body = WalkBody(parent, node.Body);
        }

        private void Declare(Scope parent, A.Decl.Var node)
        {
            if (InFuncy)
            {
                var function = CurrentFuncy;

                var decl = parent.Declare(new Decl.LetVar(parent, node, true, function.Parameters.Count + function.Locals.Count));
                function.Locals.Add(decl);
                function.Members.Add(decl);
            }
            else
            {
                Assert(InClass);

                var klass = CurrentClass;

                var decl = parent.Declare(new Decl.Field(parent, node, true));
                klass.Fields.Add(decl);
                klass.Members.Add(decl);
            }
        }

        private void Declare(Scope parent, A.Decl.Let node)
        {
            if (InFuncy)
            {
                var function = CurrentFuncy;

                var decl = parent.Declare(new Decl.LetVar(parent, node, false, function.Parameters.Count + function.Locals.Count));
                function.Locals.Add(decl);
                function.Members.Add(decl);
            }
            else
            {
                Assert(InClass);

                var klass = CurrentClass;

                var decl = parent.Declare(new Decl.Field(parent, node, false));
                klass.Fields.Add(decl);
                klass.Members.Add(decl);
            }
        }

        private void Declare(Scope container, A.Decl.TypeParameters node)
        {
            WalkDeclarations(container, node);
        }

        private void Declare(Scope container, A.Decl.Parameters node)
        {
            WalkDeclarations(container, node);
        }

        private void Declare(Scope parent, A.Decl.ValueParameter node)
        {
            var function = CurrentFuncy;
            var scope = function.Scope;

            var param = scope.Declare(
                new Decl.Parameter(
                    scope, 
                    node, 
                    function.Parameters.Count,
                    node.Default == null ? null : ResolveExpression(scope, node.Default)));
            function.Parameters.Add(param);
        }
    }
}
