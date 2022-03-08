using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class BlockScope : ScopeCore
    {
        [DebuggerStepThrough]
        public BlockScope(string name, Scope parent)
            : base(name, parent)
        {
        }

        [DebuggerStepThrough]
        public BlockScope(A.Decl decl, Scope parent)
            : base(decl.Name.Text, parent)
        {
        }
    }
}
