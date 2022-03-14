using Six.Six.Sema;

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
            Emit(stmt.Left);
            Emit(stmt.Right);
            Emit(Insn.ToDo("assign"));
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
