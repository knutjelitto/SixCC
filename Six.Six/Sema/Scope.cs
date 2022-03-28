
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Scope
    {
        Scope Parent { get; }
        public Module Module => Parent.Module;
        public Resolver Resolver => Module.Resolver;
        T Declare<T>(T decl, string? name = null) where T : Decl;
        Decl Resolve(A.TreeNode tree, string name);
    }
}
