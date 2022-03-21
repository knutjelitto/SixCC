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
            if (node.Satisfies != null)
            {
            }

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

        private void DeclareFunction(Decl.Function decl, A.Decl.Function node)
        {
            var isMethod = decl.Parent is ClassBlock;
            var classy = (decl.Parent as ClassBlock)?.Classy;
            decl.Parent.Members.Add(decl);

            if (isMethod && !decl.IsStatic)
            {
                Assert(classy != null);
                DeclareSelf(decl.Block, classy);
            }
            WalkDeclarations(decl.Block, node.Parameters);
            WalkBody(decl.Block, node.Body);
        }

        private void Declare(Block parent, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            DeclareFunction(new Decl.Function(parent, node, InfixName(node)), node);
        }

        private void Declare(Block parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            DeclareFunction(new Decl.Function(parent, node, PrefixName(node)), node);
        }

        private void Declare(Block parent, A.Decl.Function node)
        {
            Assert(node.Parameters.Count >= 0);

            DeclareFunction(new Decl.Function(parent, node, null), node);
        }

        private void Declare(ClassBlock parent, A.Decl.Attribute node)
        {
            var classy = parent.Classy;

            var decl = new Decl.Attribute(parent, node);

            classy.Block.Members.Add(decl);

            DeclareSelf(decl.Block, classy);
            WalkBody(decl.Block, node.Body);
        }

        private void Declare(ClassBlock parent, A.Decl.Constructor node)
        {
            var klass = (Decl.Class)parent.Classy;

            var decl = new Decl.Constructor(parent, klass, node);

            klass.Block.Members.Add(decl);

            DeclareSelf(decl.Block, klass);
            WalkDeclarations(decl.Block, node.Parameters);
            WalkBody(decl.Block, node.Body);

            var lazy = new LazyExpr(Module, () => new Expr.ParameterReference(decl.Parameters[0]));
            var ret = new Stmt.Return(node.GetLocation(), decl.Block, decl, lazy);
            decl.Block.Members.Add(ret);
        }

        private void DeclareSelf(FuncBlock block, Decl.Classy classy)
        {
            var self = new Decl.SelfParameter(block, classy.Type, 0);
            block.Head.Declare(self, Names.Core.SelfValue);
            block.Funcy.AddParameter(self);
        }

        private void Declare(Block parent, A.Decl.Alias node)
        {
            var decl = new Decl.Alias(parent, node);
        }

        private void Declare(Block parent, A.Decl.Var node)
        {
            DeclareLetVarField(parent, node, true);
        }

        private void Declare(Block parent, A.Decl.Let node)
        {
            DeclareLetVarField(parent, node, false);
        }

        private void DeclareLetVarField(Block parent, A.Decl node, bool writeable)
        {
            if (parent is FuncBlock codeBlock)
            {
                var function = codeBlock.Funcy;

                var decl = parent.Content.Declare(new Decl.LetVar(parent, node, writeable, function.Parameters.Count + function.Locals.Count));
                function.Locals.Add(decl);
                function.Block.Members.Add(decl);
            }
            else if (parent is ClassBlock classBock)
            {
                var classy = classBock.Classy;

                var decl = parent.Content.Declare(new Decl.Field(parent, node, writeable));
                classy.Fields.Add(decl);
                classy.Block.Members.Add(decl);
            }
            else if (parent is NamespaceBlock namespaceBlock)
            {
                var decl = parent.Content.Declare(new Decl.Global(parent, node, writeable));
                namespaceBlock.Members.Add(decl);
            }
            else
            {
                Assert(false);
                throw new NotImplementedException();
            }
        }

        private void Declare(Block block, A.Decl.TypeParameters node)
        {
            WalkDeclarations(block, node);
        }

        private void Declare(Block block, A.Decl.Parameters node)
        {
            WalkDeclarations(block, node);
        }

        private void Declare(Block parent, A.Decl.ValueParameter node)
        {
            var funcy = (FuncBlock)parent;

            var function = funcy.Funcy;

            var param = funcy.Head.Declare(
                new Decl.Parameter(
                    funcy, 
                    node, 
                    function.Parameters.Count,
                    node.Default == null ? null : ResolveExpression(funcy.Head, node.Default)));
            function.AddParameter(param);
        }
    }
}
