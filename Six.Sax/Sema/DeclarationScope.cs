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
    }
}
