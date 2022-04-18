using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        ILocation Location { get; }
        bool Validated { get; set; }
        Type Type { get; }

        public sealed class Unreachable : StmtImpl
        {
            public Unreachable(ILocation location, CodeBlock block)
                : base(location, block)
            {
            }

            public Decl.Funcy Funcy => Block.Funcy;
        }

        public sealed class If : StmtImpl
        {
            private readonly LazyExpr lazyCondition;
            public If(ILocation location, CodeBlock block, LazyExpr lazyCondition, CodeBlock ifBlock, CodeBlock? elseBlock)
                : base(location, block)
            {
                this.lazyCondition = lazyCondition;
                IfBlock = ifBlock;
                ElseBlock = elseBlock;
            }

            public Expr Condition => lazyCondition.Value;
            public CodeBlock IfBlock { get; }
            public CodeBlock? ElseBlock { get; }

            public override Type Type
            {
                get
                {
                    if (ElseBlock == null)
                    {
                        return IfBlock.StmtsType;
                    }
                    var t1 = IfBlock.StmtsType;
                    var t2 = IfBlock.StmtsType;

                    Assert(ReferenceEquals(Module.Resolver.T.Lower(t1), Module.Resolver.T.Lower(t2)));

                    return t1;
                }
            }
        }

        public sealed class While : StmtImpl
        {
            private readonly LazyExpr lazyCondition;
            public While(ILocation location, CodeBlock block, LazyExpr lazyCondition, CodeBlock whileBlock)
                : base(location, block)
            {
                this.lazyCondition = lazyCondition;
                WhileBlock = whileBlock;
            }

            public Expr Condition => lazyCondition.Value;
            public CodeBlock WhileBlock { get; }

            public override Type Type => WhileBlock.StmtsType;
        }

        public sealed class Return : StmtImpl
        {
            private readonly LazyExpr? lazyExpr;

            public Return(ILocation location, CodeBlock block, LazyExpr? delayed)
                : base(location, block)
            {
                lazyExpr = delayed;
            }

            public Decl.Funcy Funcy => Block.Funcy;

            public Expr? Expr => lazyExpr?.Value;

            public override Type Type => Expr != null ? Expr.Type : base.Type;
        }

        public sealed class Assign : StmtImpl
        {
            private readonly LazyExpr lazyLeft;
            private readonly LazyExpr lazyRight;

            public Assign(ILocation location, CodeBlock block, LazyExpr left, LazyExpr right)
                : base(location, block)
            {
                lazyLeft = left;
                lazyRight = right;
            }

            public Expr Left => lazyLeft.Value;
            public Expr Right => lazyRight.Value;
        }

        public sealed class Expression : StmtImpl
        {
            private readonly LazyExpr lazyExpr;

            public Expression(ILocation location, CodeBlock block, LazyExpr expr)
                : base(location, block)
            {
                lazyExpr = expr;
            }

            public Expr Expr => lazyExpr.Value;
        }
    }

    public abstract class StmtImpl : Stmt
    {
        protected StmtImpl(ILocation location, CodeBlock block)
        {
            Location = location;
            Block = block;
        }

        public ILocation Location { get; }
        public CodeBlock Block { get; }

        public Module Module => Block.Module;

        public bool Validated { get; set; }

        public virtual Type Type => new Type.Void(Module);
    }
}
