using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Expression
    {
        public record Reference(Entity Entity, params Type[] Arguments) : Expression;
        public record AndThen(Expression Left, Expression Right) : Expression;
        public record OrElse(Expression Left, Expression Right) : Expression;
        public record Not(Expression Expr) : Expression;
        public record Neg(Expression Expr) : Expression;
        public record Identical(Expression Left, Expression Right) : Expression;
        public record NotIdentical(Expression Left, Expression Right) : Expression;
        public record Add(Expression Left, Expression Right) : Expression;
        public record Sub(Expression Left, Expression Right) : Expression;
        public record Mul(Expression Left, Expression Right) : Expression;
        public record Div(Expression Left, Expression Right) : Expression;
        public record Rem(Expression Left, Expression Right) : Expression;
    }
}
