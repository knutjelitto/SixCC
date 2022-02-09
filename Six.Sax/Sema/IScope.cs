using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface IScope
    {
        Module Module { get; }
        bool TryFind(A.Name name, [MaybeNullWhen(false)] out A.With.Name? node);
    }
}
