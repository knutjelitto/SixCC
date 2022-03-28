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
        private void WalkDeclarations(Block block, IEnumerable<A.Decl> nodes)
        {
            foreach (var node in nodes)
            {
                WalkDeclaration(block, node);
            }
        }

        private void WalkDeclaration(Block block, A.Decl node)
        {
            Declare((dynamic)block, (dynamic)node);
        }

        private void Declare(Block block, A.Decl node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void DeclareClassyBody(Decl.Classy decl, A.Decl.Classy node)
        {
            WalkBody(decl.Block, node.Body);
        }

        //**

        private void Declare(Block parent, A.Decl.Class node)
        {
            var decl = new Decl.Class(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Block parent, A.Decl.Interface node)
        {
            var decl = new Decl.Interface(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Block parent, A.Decl.Object node)
        {
            var decl = new Decl.Object(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void DeclareFunction(Decl.Funcy decl, A.Decl.Funcy node)
        {
            if (decl.Parent is ClassBlock classBlock && !decl.IsStatic)
            {
                DeclareSelf(decl.Block, classBlock.Classy);
            }

            WalkDeclarations(decl.Block, ((A.With.Parameters)node).Parameters);
            WalkBody(decl.Block, node.Body);
        }

        private void Declare(Block parent, A.Decl.Attribute node)
        {
            Assert(node.Parameters.Count == 0);

            DeclareFunction(new Decl.Attribute(parent, node), node);
        }

        private void Declare(Block parent, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            DeclareFunction(new Decl.Function(parent, node, node.InfixName()), node);
        }

        private void Declare(Block parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            DeclareFunction(new Decl.Function(parent, node, node.PrefixName()), node);
        }

        private void Declare(Block parent, A.Decl.Function node)
        {
            DeclareFunction(new Decl.Function(parent, node, null), node);
        }

        private void Declare(ClassBlock parent, A.Decl.Constructor node)
        {
            var decl = new Decl.Constructor(parent, node);

            var klass = (Decl.Class)parent.Classy;

            if (decl.IsNative)
            {
                Assert(true);

                WalkDeclarations(decl.Block, node.Parameters);
                WalkBody(decl.Block, node.Body);
#if false
                var lazy = new LazyExpr(Module, () => new Expr.ParameterReference(decl.Parameters.First()));
                _ = new Stmt.Return(node.GetLocation(), decl.Block, lazy);
#endif
            }
            else
            {

                DeclareSelf(decl.Block, klass);
                WalkDeclarations(decl.Block, node.Parameters);
                WalkBody(decl.Block, node.Body);

                var lazy = new LazyExpr(Module, () => new Expr.ParameterReference(decl.Parameters.First()));
                _ = new Stmt.Return(node.GetLocation(), decl.Block, lazy);
            }
        }

        private void DeclareSelf(FuncBlock block, Decl.Classy classy)
        {
            _ = new Decl.SelfParameter(block, classy.Type);
        }

        private void Declare(Block parent, A.Decl.Alias node)
        {
            _ = new Decl.Alias(parent, node);
        }

        private void Declare(FuncBlock parent, A.Decl.Var node)
        {
            parent.Content.Declare(new Decl.LetVar(parent, node, true));
        }

        private void Declare(FuncBlock parent, A.Decl.Let node)
        {
            parent.Content.Declare(new Decl.LetVar(parent, node, false));
        }

        private void Declare(ClassBlock parent, A.Decl.Var node)
        {
            Assert(node.Type != null);
            parent.Content.Declare(new Decl.Field(parent, node, true));
        }
        private void Declare(ClassBlock parent, A.Decl.Let node)
        {
            Assert(node.Type != null);
            parent.Content.Declare(new Decl.Field(parent, node, false));
        }


        private void Declare(NamespaceBlock parent, A.Decl.Var node)
        {
            Assert(node.Type != null);
            parent.Content.Declare(new Decl.Global(parent, node, true));
        }

        private void Declare(NamespaceBlock parent, A.Decl.Let node)
        {
            Assert(node.Type != null);
            parent.Content.Declare(new Decl.Global(parent, node, false));
        }

        private void Declare(Block block, A.Decl.TypeParameters node)
        {
            WalkDeclarations(block, node);
        }

        private void Declare(Block block, A.Decl.Parameters node)
        {
            WalkDeclarations(block, node);
        }

        private void Declare(FuncBlock parent, A.Decl.ValueParameter node)
        {
            _ = parent.Head.Declare(
                new Decl.Parameter(
                    parent, 
                    node, 
                    node.Default == null ? null : ResolveExpression(parent, node.Default)));
        }
    }
}
