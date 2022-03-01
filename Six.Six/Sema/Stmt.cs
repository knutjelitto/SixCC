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
            : Statement(Container, AStmt, Insn.Return)
        {
            public Expr.Delayed? Expr { get; set; } = null;

            public override void Emit(Writer writer)
            {
                var emitter = new Emitter();

                if (Expr != null)
                {
                    Assert(Expr.Resolved != null);
                    Expr.Resolved.Emit(emitter);
                }
                emitter.Add(Insn.Return);

                emitter.Dump(writer);
            }
        }
    }

    public record Statement(Scope Container, A.Stmt AStmt, params Insn[] Insns) : Stmt
    {
        public virtual void Emit(Writer writer)
        {
            foreach (var insn in Insns)
            {
                writer.WriteLine($"{insn}");
            }
        }
    }
}
