using Six.Core;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        ILocation Location { get; }
        Errors Errors { get; }
        bool Validated { get; }

        bool Validated { get; set; }

        public sealed class Return : Statement
        {
            private readonly LazyExpr? lazyExpr;

            public Return(ILocation location, FuncBlock block, LazyExpr? delayed)
                : base(location, block)
            {
                Funcy = block.Funcy;
                lazyExpr = delayed;
            }

            public Decl.Funcy Funcy { get; }

            public Expr? Expr => lazyExpr?.Expr;
        }

        public sealed class Assign : Statement
        {
            private readonly LazyExpr lazyLeft;
            private readonly LazyExpr lazyRight;

            public Assign(A.Stmt.Assign stmt, FuncBlock block, LazyExpr left, LazyExpr right)
                : base(stmt.GetLocation(), block)
            {
                lazyLeft = left;
                lazyRight = right;
            }

            public Expr Left => lazyLeft.Expr;
            public Expr Right => lazyRight.Expr;
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
