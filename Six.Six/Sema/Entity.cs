using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Entity : WithContainer
    {
        public bool IsShared => this.IsShared();
        public bool IsNative => this.IsNative();

        A.TreeNode Ast { get; }
    }
}
