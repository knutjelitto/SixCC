using Six.Core;
using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        ILocation Location { get; }
        Errors Errors { get; }

        bool Validated { get; set; }

        public sealed class Return : Statement
        {
            private readonly LazyExpr? delayed;

            public Return(ILocation location, FuncBlock block, LazyExpr? delayed)
                : base(location, block)
            {
                Funcy = block.Funcy;
                this.delayed = delayed;
            }

            public Decl.Funcy Funcy { get; }

            public Expr? Expr => delayed?.Expr;
        }

        public sealed class Assign : Statement
        {
            private readonly LazyExpr left;
            private readonly LazyExpr right;

            public Assign(A.Stmt.Assign stmt, FuncBlock block, LazyExpr left, LazyExpr right)
                : base(stmt.GetLocation(), block)
            {
                this.left = left;
                this.right = right;
            }

            public Expr Left => left.Expr;
            public Expr Right => right.Expr;
        }
    }

    public abstract class Statement : Stmt
    {
        public Statement(ILocation location, FuncBlock block)
        {
            Location = location;
            Block = block;
            block.Members.Add(this);
        }

        public ILocation Location { get; }
        public FuncBlock Block { get; }
        public Scope Container => Block.Content;

        public Module Module => Block.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;

        public bool Validated { get; set; }
    }
}
