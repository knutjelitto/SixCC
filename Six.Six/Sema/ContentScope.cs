using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContentScope : DeclarationScope
    {
        protected ContentScope(Scope parent, string name)
            : base(name, parent)
        {
            Block = new BlockScope("block", this);
        }

        public BlockScope Block { get; }
    }

    public class ClassyScope : ContentScope
    {
        public ClassyScope(Scope parent, string name)
            : base(parent, name)
        {
        }
    }

    public class FuncyScope : ContentScope
    {
        public FuncyScope(Scope parent, string name)
            : base(parent, name)
        {
        }
    }
}
