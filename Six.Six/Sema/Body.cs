using System;

namespace Six.Six.Sema
{
    public interface Body
    {
        public record Expression(Func<Expr> Resolver) : Body
        {
            private Expr? concrete;
            public Expr Expr => concrete ??= Resolver();
        }

        public record Block(Func<Expr> Resolver) : Body
        {
            private Expr? concrete;
            public Expr Expr => concrete ??= Resolver();
        }

        public record Dummy() : Body
        {
        }
    }

    public class CodeBlock : Body
    {
        public CodeBlock(Decl.Funcy funcy, Scope parent)
        {
            Funcy = funcy;
            Scope = new BlockScope(funcy.ADecl, parent);
        }

        public Decl.Funcy Funcy { get; }
        public BlockScope Scope { get; }
        public List<Member> Members { get; } = new();
    }
}
