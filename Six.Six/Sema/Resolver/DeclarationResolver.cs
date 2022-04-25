using System;

using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class DeclarationResolver : ResolverCore
    {
        public DeclarationResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

        public void WalkDeclaration(Block block, A.Decl node)
        {
            Declare((dynamic)block, (dynamic)node);
        }

        private void WalkDeclarations(Block block, IEnumerable<A.Decl> nodes)
        {
            foreach (var node in nodes)
            {
                WalkDeclaration(block, node);
            }
        }

        private void DeclareParameters(Block block, A.Decl.Funcy funcy)
        {
            foreach (var parameter in ((A.With.Parameters)funcy).Parameters)
            {
                WalkDeclaration(block, parameter);
            }
        }

        private void Declare(Block block, A.Decl node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void WalkClassBody(Decl.Classy decl, A.Decl.Classy node)
        {
            B.WalkBody(decl.Block, node.Body);
        }

        //**

        private void Declare(Block parent, A.Decl.Class node)
        {
            var decl = M.AddMember(parent, parent.Declare(new Decl.Class(parent, node)));

            WalkClassBody(decl, node);
        }

        private void Declare(Block parent, A.Decl.Interface node)
        {
            var decl = M.AddMember(parent, parent.Declare(new Decl.Interface(parent, node)));

            WalkClassBody(decl, node);
        }

        private void Declare(Block parent, A.Decl.Object node)
        {
            var decl = M.AddMember(parent, parent.Declare(new Decl.Object(parent, node)));

            WalkClassBody(decl, node);
        }

        private void DeclareFunction(Decl.Funcy decl, A.Decl.Funcy node)
        {
            if (decl.Parent is ClassBlock classBlock && !decl.IsStatic)
            {
                DeclareSelfParameter(decl.Block, classBlock.Classy);
            }

            DeclareParameters(decl.Block, node);
            B.WalkBody(decl.Block, node.Body);
        }

        private void Declare(Block parent, A.Decl.Attribute node)
        {
            Assert(node.Parameters.Count == 0);

            var decl = M.AddMember(parent, parent.Declare(new Decl.Attribute(parent, node)));

            DeclareFunction(decl, node);
        }

        private void Declare(Block parent, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            var decl = M.AddMember(parent, parent.Declare(new Decl.Function(parent, node, node.InfixName())));

            DeclareFunction(decl, node);
        }

        private void Declare(Block parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            var decl = M.AddMember(parent, parent.Declare(new Decl.Function(parent, node, node.PrefixName())));

            DeclareFunction(decl, node);
        }

        private void Declare(Block parent, A.Decl.Function node)
        {
            var decl = M.AddMember(parent, parent.Declare(new Decl.Function(parent, node, null)));

            DeclareFunction(decl, node);
        }

        private void Declare(ClassBlock parent, A.Decl.Constructor node)
        {
            var decl = M.AddMember(parent, parent.Declare(new Decl.Constructor(parent, node)));

            if (decl.IsNative)
            {
                DeclareParameters(decl.Block, node);
                B.WalkBody(decl.Block, node.Body);
            }
            else
            {
                var clazz = (Decl.Class)parent.Classy;

                DeclareSelfParameter(decl.Block, clazz);
                DeclareParameters(decl.Block, node);
                B.WalkBody(decl.Block, node.Body);

                var lazy = new LazyExpr(() => new Expr.ParameterReference(decl.Parameters[0]));
                decl.Block.CodeBlock.Add(new Stmt.Return(node.GetLocation(), decl.Block.CodeBlock, lazy));
            }
        }

        private void Declare(Block parent, A.Decl.Alias node)
        {
            M.AddMember(parent, parent.Declare(new Decl.Alias(parent, node)));
        }

        private void DeclareLetVar(CodeBlock parent, A.Decl.LetVar node, bool writeable)
        {
            var letvar = M.AddMember(parent, parent.Declare(new Decl.LetVar(parent, node, writeable)));

            parent.Add(new Stmt.Assign(
                node.GetLocation(),
                parent,
                new LazyExpr(() => new Expr.LocalReference(letvar)),
                E.ResolveExpression(parent, node.Value)));
        }

        private void Declare(CodeBlock parent, A.Decl.Var node)
        {
            DeclareLetVar(parent, node, true);
        }

        private void Declare(CodeBlock parent, A.Decl.Let node)
        {
            DeclareLetVar(parent, node, false);
        }

        private void Declare(ClassBlock parent, A.Decl.Var node)
        {
            M.AddMember(parent, parent.Declare(new Decl.Field(parent, node, true)));
        }

        private void Declare(ClassBlock parent, A.Decl.Let node)
        {
            M.AddMember(parent, parent.Declare(new Decl.Field(parent, node, false)));
        }

        private void Declare(NamespaceBlock parent, A.Decl.Var node)
        {
            M.AddMember(parent, parent.Declare(new Decl.Global(parent, node, true)));
        }

        private void Declare(NamespaceBlock parent, A.Decl.Let node)
        {
            M.AddMember(parent, parent.Declare(new Decl.Global(parent, node, false)));
        }

        private void Declare(Block block, A.Decl.TypeParameters node)
        {
            WalkDeclarations(block, node);
        }

        private void Declare(Block block, A.Decl.Parameters node)
        {
            WalkDeclarations(block, node);
        }

        private void DeclareSelfParameter(FuncBlock parent, Decl.Classy classy)
        {
            M.AddMember(parent, parent.Declare(new Decl.SelfParameter(parent, classy.Type)));
        }

        private void Declare(FuncBlock parent, A.Decl.ValueParameter node)
        {
            var parameter = parent.Declare(
                new Decl.Parameter(
                    parent,
                    node,
                    node.Default == null ? null : E.ResolveExpression(parent, node.Default)));

            M.AddMember(parent, parameter);
        }
    }
}
