using Six.Core;
using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        A.Stmt AStmt { get; }
        Insn[] Insns { get; }

        public sealed record Return(Scope Container, A.Stmt AStmt)
            : Statement(Container, AStmt, Insn.Return), Emitting
        {
            public Expr.Concrete? Expr { get; set; } = null;

            public void Emit(Emitter emitter)
            {
                if (Expr != null)
                {
                    Assert(Expr != null);
                    Expr.Emit(emitter);
                }
                emitter.Add(Insn.Return);
            }
        }
    }

    public record Statement(Scope Container, A.Stmt AStmt, params Insn[] Insns) : Stmt
    {
    }
}
