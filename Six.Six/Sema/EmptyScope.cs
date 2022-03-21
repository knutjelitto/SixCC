using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class EmptyScope : Scope
    {
        [DebuggerStepThrough]
        public EmptyScope(Module module)
        {
            Module = module;
        }
        public Scope Parent => throw new NotImplementedException();
        public Module Module { get; }
        public T Declare<T>(T decl, string? name = null) where T : Decl => throw new NotImplementedException();
        public Decl Find(A.TreeNode tree, string name) => throw new NotImplementedException();
        public Decl Resolve(A.TreeNode tree, string name)
        {
            throw Module.Errors.CantResolve(tree, name);
        }
    }
}
