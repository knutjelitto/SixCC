using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class DeclarationScope : Scope, Contained
    {
        public DeclarationScope(Container container)
            : base(container.Module)
        {
            Container = container;
        }

        public Container Container { get; }

        public override bool TryFind(A.Name name, out A.With.Name? node)
        {
#if true
            node = null;
#else
            if (!base.TryFind(name, out node))
            {
                return Up.TryFind(name, out node);
            }
#endif
            return true;
        }
    }
}
