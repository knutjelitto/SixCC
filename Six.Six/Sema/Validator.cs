using Six.Core.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void Validate(Decl.Class decl)
        {
            ValidateClassy(decl);

            Assert(slip);
        }

        private void Validate(Decl.Interface decl)
        {
            ValidateClassy(decl);

            Assert(slip);
        }

        private void Validate(Decl.Object decl)
        {
            ValidateClassy(decl);

            Assert(slip);
        }

        private void ValidateClassy(Decl.Classy decl)
        {
            Walk(decl.Block);

            Assert(slip);
        }

        private void Validate(Decl.Attribute decl)
        {
            Walk(decl.Block);

            Assert(slip);
        }

        private void Validate(Decl.Field decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Validate(Decl.Global decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Validate(Decl.LetVar decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Validate(Decl.SelfParameter decl)
        {
            Assert(slip);
        }

        private void Validate(Decl.Parameter decl)
        {
            if (decl.Default != null)
            {
                Walk(decl.Default);
            }

            Assert(slip);
        }

        private void Validate(Decl.Constructor decl)
        {
            Walk(decl.Block);

            Assert(slip);
        }

        private void Validate(Decl.Function decl)
        {
            Walk(decl.Block);

            if (decl.Parent is NamespaceBlock)
            {
                if (decl.IsStatic) Add(Errors.SubjectShouldntBeMarkedAs(decl, $"global {Names.Nomes.Function}", Names.Attr.Static));
                if (decl.IsAbstract) Add(Errors.SubjectShouldntBeMarkedAs(decl, $"global {Names.Nomes.Function}", Names.Attr.Abstract));
                if (decl.IsOverride) Add(Errors.SubjectShouldntBeMarkedAs(decl, $"global {Names.Nomes.Function}", Names.Attr.Override));
                if (decl.IsVirtual) Add(Errors.SubjectShouldntBeMarkedAs(decl, $"global {Names.Nomes.Function}", Names.Attr.Virtual));
                if (decl.IsSealed) Add(Errors.SubjectShouldntBeMarkedAs(decl, $"global {Names.Nomes.Function}", Names.Attr.Sealed));

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

        private void Validate(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Walk(stmt.Expr);

                Assert(Checker.CanAssign(stmt.Funcy.ResultType, stmt.Expr.Type));
            }

            stmt.Validated = true;

            Assert(slip);
        }

        private void Validate(Stmt.Assign stmt)
        {
            Walk(stmt.Left);
            Walk(stmt.Right);

            Assert(Checker.CanAssign(stmt.Left.Type, stmt.Right.Type));

            stmt.Validated = true;

            Assert(slip);
        }

        private void Validate(Expr.SelectField expr)
        {
            Assert(slip);
        }

        private void Validate(Expr.CallConstructor expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Validate(Expr.CallFunction expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Validate(Expr.CallIndirect expr)
        {
            Walk(expr.Value);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Validate(Expr.CallPrefixMember expr)
        {
            Walk(expr.Arg);

            Assert(slip);
        }

        private void Validate(Expr.CallInfixMember expr)
        {
            Walk(expr.Arg1);
            Walk(expr.Arg2);

            Assert(slip);
        }

        private void Validate(Expr.If expr)
        {
            Walk(expr.Condition);
            Walk(expr.Then);
            Walk(expr.Else);

            Assert(slip);
        }

        private void Validate(Expr.Reference expr)
        {
            Assert(slip);
        }

        private void Validate(Expr.ConstS32 expr)
        {
            // -- bottom
        }

        private void Validate(Expr.ConstU32 expr)
        {
            // -- bottom
        }

        private void Validate(Expr.ConstString expr)
        {
            // -- bottom
        }
    }
}
