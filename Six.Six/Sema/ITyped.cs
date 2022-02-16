using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface ITyped
    {
        public record Prefix(ITyped Expr) : ITyped;
        public record Infix(ITyped Left, ITyped Right) : ITyped;

        public record Call(ITyped Expr, params ITyped[] Arguments) : ITyped;
    }
}
