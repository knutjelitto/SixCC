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

            public Return(ILocation location, FuncBlock block, Decl.Funcy function, LazyExpr? delayed)
                : base(location, block)
            {
                Function = function;
                this.delayed = delayed;
            }

            public Decl.Funcy Function { get; }

            public Expr? Expr
            {
                get
                {
                    if (delayed != null)
                    {
                        var a = Resolver.LowerType(delayed.Expr.Type);
                        var b = Resolver.LowerType(Function.ResultType);

                        if (!ReferenceEquals(Resolver.LowerType(delayed.Expr.Type), Resolver.LowerType(Function.ResultType)))
                        {
                            Assert(false);
                            var x = Resolver.LowerType(delayed.Expr.Type);
                            var y = Resolver.LowerType(Function.ResultType);
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
        }

        public ILocation Location { get; }
        public FuncBlock Block { get; }
        public Scope Container => Block.Content;

        public Module Module => Container.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;
    }
}
