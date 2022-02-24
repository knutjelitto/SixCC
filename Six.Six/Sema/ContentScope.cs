using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContentScope : ScopeCore
    {
        protected ContentScope(Scope parent)
            : base(parent)
        {
            Block = new BlockScope(this);
        }

        public BlockScope Block { get; }
    }

    public class ClassyScope : ContentScope
    {
        public ClassyScope(Scope parent)
            : base(parent)
        {
        }
    }

    public class FuncyScope : ContentScope
    {
        public FuncyScope(Scope parent)
            : base(parent)
        {
        }
    }
}
