using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Member : Entity
    {
        Scope Container { get; }
    }
}
