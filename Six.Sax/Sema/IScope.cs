using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface IScope
    {
        Global Global { get; }
        void Declare(INamed named);
        void ToResolve(Node node);

        bool TryFind(Name name, [MaybeNullWhen(false)] out INamed? node);
    }
}
