using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public record Reference(A.TreeNode Ast, Declarations Declarations, params Type[]? Arguments)
        : Type, Expression;
}
