using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class DeclarationScope : Scope
    {
        public DeclarationScope(IScope up)
            : base(up.Global)
        {
            Up = up;
        }

        public IScope Up { get; }

        public override bool TryFind(Name name, out INamed? node)
        {
            if (!base.TryFind(name, out node))
            {
                return Up.TryFind(name, out node);
            }
            return true;
        }
    }
}
