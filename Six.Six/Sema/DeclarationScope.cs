using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class DeclarationScope : ScopeCore
    {
        [DebuggerStepThrough]
        public DeclarationScope(string name, Scope parent)
            : base(name, parent)
        {
        }
    }
}
