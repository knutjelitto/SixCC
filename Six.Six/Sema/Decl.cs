using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member, WithProps
    {
        A.Decl ADecl { get; }
        A.Name Name => ADecl.Name;
        Type? Type { get; }

        public record Classy : Decl
        {
            public Classy(Scope container, A.Decl aDecl)
            {
                Container = container;
                ADecl = aDecl;
                Type = new Type.Reference(this);
            }
            public Props Props { get; } = new Props();
            public Type? Type { get; }
            public A.Decl ADecl { get; }
            public Scope Container { get; }
        }
    }

    public record Declaration(Scope Container, A.Decl ADecl) : Decl
    {
        public Props Props { get; } = new Props();
        public Type? Type { get; set; } = null;
    }

    public static class PropsExtensions
    {
        private const string _result = "Result";
        private const string _extends = "Extends";
        private const string _expr = "Expression";

        public static Type? GetExtends(this WithProps decl)
        {
            return decl.Props.Get<Type>(_extends);
        }
        public static bool SetExtends(this WithProps decl, Type? type)
        {
            return decl.Props.TrySet(_extends, type);
        }

        public static Expr? GetExpr(this WithProps decl)
        {
            return decl.Props.Get<Expr>(_expr);
        }
        public static bool SetExpr(this WithProps decl, Expr? expr)
        {
            return decl.Props.TrySet(_expr, expr);
        }

        public static Type? GetResult(this WithProps decl)
        {
            return decl.Props.Get<Type>(_result);
        }
        public static bool SetResult(this WithProps decl, Type? type)
        {
            return decl.Props.TrySet(_result, type);
        }
    }

}
