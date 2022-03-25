using System;

using Six.Core.Errors;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

using Six.Core.Errors;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Sema
{
    public class Validator
    {
        const bool slip = true;

        public Validator(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Errors Errors => Module.Errors;
        public TypeChecker Checker => Module.Checker;

        public void Validate()
        {
            foreach (var nameSpace in Module.GetNamespaces())
            {
                Walk(nameSpace);
            }
        }

        private void Add(DiagnosticException error)
        {
            Module.Add(error);
        }

        private void Walk(Block block)
        {
            foreach (var member in block.Members)
            {
                Walk(member);
            }
        }

        private void Walk(Entity entity)
        {
            try
            {
                Validate((dynamic)entity);
            }
            catch (DiagnosticException diagnostic)
            {
                Module.Add(diagnostic);
            }
        }

        private void Walk(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                Walk(entity);
            }
        }

        private void Validate(Entity entity)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Validate(Decl decl)
        {
            Decl((dynamic)decl);
        }

        private void Decl(Decl.Class decl)
        {
            ClassyDecl(decl);

            Assert(slip);
        }

        private void Decl(Decl.Interface decl)
        {
            ClassyDecl(decl);

            Assert(slip);
        }

        private void Decl(Decl.Object decl)
        {
            ClassyDecl(decl);

            if (!decl.IsAbstract)
            {
                foreach (var slot in decl.Layout.Slots)
                {
                    if (!slot.Funcy.IsAbstract)
                    {
                        continue;
                    }

                    var subject = $"the {Names.Attr.Abstract} member";

                    Add(Errors.AbstractNotImplemented(decl, slot.Funcy, subject));
                }
            }

            Assert(slip);
        }

        private void ClassyDecl(Decl.Classy decl)
        {
            decl.Layout.Run();

            Walk(decl.Block);

            Assert(slip);
        }

        private void Decl(Decl.Field decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Decl(Decl.Global decl)
        {
            Walk(decl.Value);

            if (!Checker.CanAssign(decl.Type, decl.Value.Type))
            {
                Add(Errors.TypeMismatch(decl.ALetVar.Value, decl.Type, decl.Value.Type));
            }

            Assert(slip);
        }

        private void Decl(Decl.LetVar decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Decl(Decl.SelfParameter decl)
        {
            Assert(slip);
        }

        private void Decl(Decl.Parameter decl)
        {
            if (decl.Default != null)
            {
                Walk(decl.Default);
            }

            Assert(slip);
        }

        private void Decl(Decl.Funcy decl)
        {
            Walk(decl.Block);

            FuncyDecl((dynamic)decl);
        }

        private void FuncyDecl(Decl.Constructor decl)
        {
            Walk(decl.Block);

            Assert(slip);
        }

        private void FuncyDecl(Decl.Attribute decl)
        {
            Walk(decl.Block);

            Assert(slip);
        }

        private void FuncyDecl(Decl.Function decl)
        {
            if (decl.Parent is NamespaceBlock)
            {
                var subject = $"global {Names.Nouns.Function}";

                if (decl.IsStatic) Add(Errors.SubjectShouldntBeMarkedAs(decl, subject, Names.Attr.Static));
                if (decl.IsAbstract) Add(Errors.SubjectShouldntBeMarkedAs(decl, subject, Names.Attr.Abstract));
                if (decl.IsOverride) Add(Errors.SubjectShouldntBeMarkedAs(decl, subject, Names.Attr.Override));
                if (decl.IsVirtual) Add(Errors.SubjectShouldntBeMarkedAs(decl, subject, Names.Attr.Virtual));
                if (decl.IsSealed) Add(Errors.SubjectShouldntBeMarkedAs(decl, subject, Names.Attr.Sealed));
                if (!decl.HasBody) Add(Errors.SubjectShouldBeImplemented(decl, subject));

                Assert(slip);
            }
            else if (decl.Parent is ClassBlock)
            {
                Assert(slip);
            }
            else if (decl.Parent is FuncBlock)
            {
                Assert(slip);
            }
            else
            {
                Assert(false);
                throw new NotImplementedException();
            }
        }

        private void Validate(Stmt stmt)
        {
            Stmt((dynamic)stmt);

            stmt.Validated = true;

            Assert(slip);
        }

        private void Stmt(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Walk(stmt.Expr);

                Assert(Checker.CanAssign(stmt.Funcy.ResultType, stmt.Expr.Type));
            }
        }

        private void Stmt(Stmt.Assign stmt)
        {
            Walk(stmt.Left);
            Walk(stmt.Right);

            Assert(Checker.CanAssign(stmt.Left.Type, stmt.Right.Type));
        }

        private void Validate(Expr expr)
        {
            Expr((dynamic)expr);
        }

        private void Expr(Expr.SelectField expr)
        {
            Assert(slip);
        }

        private void Expr(Expr.CallConstructor expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallFunction expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallIndirect expr)
        {
            Walk(expr.Value);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallPrefixMember expr)
        {
            Walk(expr.Arg);

            Assert(slip);
        }

        private void Expr(Expr.CallInfixMember expr)
        {
            Walk(expr.Arg1);
            Walk(expr.Arg2);

            Assert(slip);
        }

        private void Expr(Expr.If expr)
        {
            Walk(expr.Condition);
            Walk(expr.Then);
            Walk(expr.Else);

            Assert(slip);
        }

        private void Expr(Expr.Reference expr)
        {
            Assert(slip);
        }

        private void Expr(Expr.ConstS32 expr)
        {
            // -- bottom
        }

        private void Expr(Expr.ConstU32 expr)
        {
            // -- bottom
        }

        private void Expr(Expr.ConstString expr)
        {
            // -- bottom
        }
    }
}
