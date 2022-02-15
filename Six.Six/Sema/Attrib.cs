using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Attrib
    {
        public Attrib(Container context, A.TreeNode self)
        {
            Context = context;
            Self = self;
        }

        public Container Context { get; }
        public A.TreeNode Self { get; }
    }
}
