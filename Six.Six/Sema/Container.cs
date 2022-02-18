using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Container
    {
        Container Parent { get; }
        public Module Module => Parent.Module;
        IReadOnlyList<A.TreeNode> Children { get; }
        T AddChild<T>(T node) where T : A.TreeNode;
        Declarations Resolve(A.Reference reference);

        public static Container Empty(Container parent)
        {
            return new EmptyContainer(parent);
        }

        private class EmptyContainer : Container
        {
            public EmptyContainer(Container parent)
            {
                Parent = parent;
            }
            public Container Parent { get; }
            public IReadOnlyList<A.TreeNode> Children { get; } = Array.Empty<A.TreeNode>();
            public T AddChild<T>(T node) where T: A.TreeNode => throw new NotImplementedException();
            public Declarations Resolve(A.Reference reference) => Parent.Resolve(reference);
        }
    }
}
