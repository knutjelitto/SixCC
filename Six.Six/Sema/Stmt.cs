using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        ILocation Location { get; }
        Errors Errors { get; }
        bool Validated { get; set; }

        public sealed class Block : Statement
        {
            public Block(ILocation location, CodeBlock block, List<Stmt> stmts)
                : base(location, block)
            {
                Stmts = stmts;
            }

            public List<Stmt> Stmts { get; }
        }

        public sealed class Unreachable : Statement
        {
            public Unreachable(ILocation location, CodeBlock block)
                : base(location, block)
            {
            }

            public Decl.Funcy Funcy => Block.Funcy;
        }

        public sealed class If : Statement
        {
            private readonly LazyExpr lazyCondition;
            public If(ILocation location, CodeBlock block, LazyExpr lazyCondition, CodeBlock ifBlock, CodeBlock? elseBlock)
                : base(location, block)
            {
                this.lazyCondition = lazyCondition;
                IfBlock = ifBlock;
                ElseBlock = elseBlock;
            }

            public Expr Condition => lazyCondition.Expr;
            public CodeBlock IfBlock { get; }
            public CodeBlock? ElseBlock { get; }
        }

        public sealed class Return : Statement
        {
            private readonly LazyExpr? lazyExpr;

            public Return(ILocation location, CodeBlock block, LazyExpr? delayed)
                : base(location, block)
            {
                lazyExpr = delayed;
            }

            public Decl.Funcy Funcy => Block.Funcy;

            public Expr? Expr => lazyExpr?.Expr;
        }

        public sealed class Assign : Statement
        {
            private readonly LazyExpr lazyLeft;
            private readonly LazyExpr lazyRight;

            public Assign(ILocation location, CodeBlock block, LazyExpr left, LazyExpr right)
                : base(location, block)
            {
                lazyLeft = left;
                lazyRight = right;
            }

            public Expr Left => lazyLeft.Expr;
            public Expr Right => lazyRight.Expr;
        }

        public sealed class Expression : Statement
        {
            private readonly LazyExpr lazyExpr;

            public Expression(ILocation location, CodeBlock block, LazyExpr expr)
                : base(location, block)
            {
                lazyExpr = expr;
            }

            public Expr Expr => lazyExpr.Expr;
        }
    }

    public abstract class Statement : Stmt
    {
        public Statement(ILocation location, CodeBlock block)
        {
            Location = location;
            Block = block;
            block.Members.Add(this);
        }

        public ILocation Location { get; }
        public CodeBlock Block { get; }

        public Module Module => Block.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;

        public bool Validated { get; set; }
    }
}
