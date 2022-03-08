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

        [DebuggerStepThrough]
        public DeclarationScope(A.Decl decl, Scope parent)
            : this(decl.Name.Text, parent)
        {
        }
    }
}
