using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    [DebuggerStepThrough]
    public record Reference(Assoc Assoc, Type Type, A.Decl Decl, params Type[]? Arguments)
        : Type, Expression;
}
