using static Six.Six.Ast.Using.Element;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface WithName : Entity
    {
        A.Name Name { get; }
    }
}
