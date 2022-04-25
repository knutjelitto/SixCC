using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Scope
    {
        Scope Parent { get; }
        public Module Module => Parent.Module;
        T Declare<T>(T decl) where T : Decl;
        Decl Resolve(A.TreeNode tree, string name);
    }
}
