using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class BlockScope : ScopeCore
    {
        [DebuggerStepThrough]
        public BlockScope(Module module, string name, Scope parent)
            : base(module, parent, name)
        {
        }
    }
}
