﻿using Six.Core;
using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        A.Stmt AStmt { get; }
        Errors Errors { get; }

        public sealed class Return : Statement
        {
            private readonly LazyExpr? delayed;

            public Return(Scope container, A.Stmt.Return stmt, Decl.Function function, LazyExpr? delayed)
                : base(container, stmt)
            {
                Function = function;
                Stmt = stmt;
                this.delayed = delayed;
            }

            public Decl.Function Function { get; }
            public A.Stmt.Return Stmt { get; }

            public Expr? Expr
            {
                get
                {
                    if (delayed != null)
                    {
                        if (!ReferenceEquals(Resolver.LowerType(delayed.Expr.Type), Resolver.LowerType(Function.ResultType)))
                        {
                            Assert(false);
                            throw Errors.TypeMismatch(Stmt.Expression, Function.ResultType, delayed.Expr.Type);
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

            public Assign(Scope container, A.Stmt.Assign stmt, LazyExpr left, LazyExpr right)
                : base(container, stmt)
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
        public Statement(Scope container, A.Stmt aStmt)
        {
            Container = container;
            AStmt = aStmt;
        }

        public Scope Container { get; }
        public A.Stmt AStmt { get; }
        public A.TreeNode ANode => AStmt;

        public Module Module => Container.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;
    }
}
