using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContentScope : DeclarationScope
    {
        protected ContentScope(string name, Scope parent)
            : base(name, parent)
        {
            Block = new BlockScope("block", this);
        }

        public BlockScope Block { get; }
    }

    public class ClassyScope : ContentScope
    {
        public ClassyScope(string name, Scope parent)
            : base(name, parent)
        {
        }
    }

    public class FuncyScope : ContentScope
    {
        public FuncyScope(string name, Scope parent)
            : base(name, parent)
        {
        }
    }
}
