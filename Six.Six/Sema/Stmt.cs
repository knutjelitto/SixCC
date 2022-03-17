using Six.Core;
using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        ILocation Location { get; }
        Errors Errors { get; }

        public sealed class Return : Statement
        {
            private readonly LazyExpr? delayed;

            public Return(ILocation location, Scope container, Decl.Function function, LazyExpr? delayed)
                : base(location, container)
            {
                Function = function;
                this.delayed = delayed;
            }

            public Decl.Function Function { get; }

            public Expr? Expr
            {
                get
                {
                    if (delayed != null)
                    {
                        if (!ReferenceEquals(Resolver.LowerType(delayed.Expr.Type), Resolver.LowerType(Function.ResultType)))
                        {
                            Assert(false);
                            throw Errors.TypeMismatch(Location, Function.ResultType, delayed.Expr.Type);
                        }
                    }
                    return delayed?.Expr;
                }
            }
        }

        public sealed class Assign : Statement
        {
            private readonly LazyExpr left;
            private readonly LazyExpr right;

            public Assign(A.Stmt.Assign stmt, Scope container, LazyExpr left, LazyExpr right)
                : base(stmt.GetLocation(), container)
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
        public Statement(ILocation location, Scope container)
        {
            Location = location;
            Container = container;
        }

        public ILocation Location { get; }
        public Scope Container { get; }

        public Module Module => Container.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;
    }
}
