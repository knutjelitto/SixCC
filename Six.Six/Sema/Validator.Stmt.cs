using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public partial class Validator
    {
        private void Validate(Stmt stmt)
        {
            Stmt((dynamic)stmt);

            stmt.Validated = true;

            Assert(slip);
        }

        private void Stmt(Stmt stmt)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Stmt(Stmt.Expression stmt)
        {
            Walk(stmt.Expr);
        }

        private void Stmt(Stmt.Unreachable stmt)
        {
            Assert(stmt.Funcy.IsAbstract || stmt.Funcy.IsNative);
        }

        private void Stmt(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Walk(stmt.Expr);

                if (!Checker.CanAssign(stmt.Funcy.ResultType, stmt.Expr.Type))
                {
                    Add(Errors.TypeMismatch(stmt.Location, stmt.Funcy.ResultType, stmt.Expr.Type));
                }
            }
        }

        private void Stmt(Stmt.Assign stmt)
        {
            Walk(stmt.Left);
            Walk(stmt.Right);

            Assert(Checker.CanAssign(stmt.Left.Type, stmt.Right.Type));
        }

    }
}
