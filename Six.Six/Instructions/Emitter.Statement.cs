﻿using Six.Six.Sema;
using System;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        private void Handle(Stmt stmt)
        {
            Assert(stmt.Validated);

            HandleStmt((dynamic) stmt);
        }

        private void HandleStmt(Stmt stmt)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void HandleStmt(Stmt.Unreachable stmt)
        {
            Emit(Insn.Unreachable);
        }

        private void HandleStmt(Stmt.Expression stmt)
        {
            Emit(stmt.Expr);
        }

        private void HandleStmt(Stmt.Assign stmt)
        {
            switch (stmt.Left)
            {
                case Expr.SelectField select:
                    Emit(select.Reference);
                    Emit(stmt.Right);
                    Emit(Lower(select.Field.Type).Store(select.Field.Offset));
                    return;
                case Expr.GlobalReference globalReference:
                    Emit(stmt.Right);
                    Emit(Insn.Global.Set(globalReference.Decl.FullName));
                    return;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private void HandleStmt(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Emit(stmt.Expr);
            }
            Emit(Insn.Return);
        }
    }
}
