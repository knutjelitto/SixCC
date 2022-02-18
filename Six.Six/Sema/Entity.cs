using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Entity : WithContainer
    {
        public bool IsShared => Ast.IsShared();
        public bool IsNative => Ast.IsNative();

        A.TreeNode Ast { get; }
    }
}
