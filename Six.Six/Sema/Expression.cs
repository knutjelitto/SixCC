using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Expression : Type, Entity
    {
        Type Type { get; }

        public record Call(Assoc Assoc, Type Type, Callable Expr, params Expression[] Arguments) : Expression;
        public record CallCtor(Assoc Assoc, Type Type, Expression Expr, params Expression[] Arguments) : Expression;
        public record Select(Assoc Assoc, Expression Expr, Expression Member) : Expression
        {
            public Type Type => Member;
        };

        public record Callable(Assoc Assoc, Type Type, params Type[] Arguments) : Expression;
        public record Attribute(Assoc Assoc, Type Type) : Expression;
        public record Parameter(Assoc Assoc, Type Type) : Expression;
        public record Var(Assoc Assoc, Type Type, Expression Value) : Expression;
        public record Let(Assoc Assoc, Type Type, Expression Value) : Expression;
        public record Class(Assoc Assoc, Type Type) : Expression;

        public record NaturalLiteral(Assoc Assoc, Type Type, ulong Value) : Expression;
    }
}
