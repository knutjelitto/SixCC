using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class MemberScope : ContainerCore
    {
        protected MemberScope(Container parent)
            : base(parent)
        {
            Members = new BlockScope(this);
        }

        public BlockScope Members { get; }
    }

    public abstract class WhiteMemberScope : MemberScope
    {
        protected WhiteMemberScope(Container parent)
            : base(parent)
        {
        }
    }

    public class ClassyScope : WhiteMemberScope
    {
        public ClassyScope(Container parent)
            : base(parent)
        {
        }
    }

    public class FunctionScope : MemberScope
    {
        public FunctionScope(Container parent)
            : base(parent)
        {
        }
    }
}
