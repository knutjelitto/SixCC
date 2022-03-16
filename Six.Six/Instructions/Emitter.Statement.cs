using Six.Six.Sema;
using System;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        private void Handle(Stmt stmt)
        {
            Assert(false);
        }

        private void Handle(Stmt.Assign stmt)
        {
            switch (stmt.Left)
            {
                case Expr.SelectField select:
                    Emit(stmt.Right);
                    Emit(select.Reference);
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

        private void Handle(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Emit(stmt.Expr);
            }
            Emit(Insn.Return);
        }
    }
}
