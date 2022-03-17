using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContentScope : DeclarationScope
    {
        protected ContentScope(Scope parent, string name)
            : base(parent, name)
        {
        }
    }

    public class ClassyScope : ContentScope
    {
        public ClassyScope(Scope parent, string name)
            : base(parent, name)
        {
        }
    }

    public class FuncyScope : DeclarationScope
    {
        public FuncyScope(Scope parent, string name)
            : base(parent, name)
        {
        }
    }
}
