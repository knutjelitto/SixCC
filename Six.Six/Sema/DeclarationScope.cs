using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class DeclarationScope : ScopeCore
    {
        [DebuggerStepThrough]
        public DeclarationScope(Scope parent)
            : base(parent)
        {
        }
    }
}
