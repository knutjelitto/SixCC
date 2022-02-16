using Six.Runtime.Types;
using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Container
    {
        Container Parent { get; }
        public Module Module => Parent.Module;
        IReadOnlyList<Entity> Children { get; }
        Entity AddChild(Entity entity);
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
            public IReadOnlyList<Entity> Children { get; } = Array.Empty<Entity>();
            public Entity AddChild(Entity entity) => throw new NotImplementedException();
            public Declarations Resolve(A.Reference reference) => Parent.Resolve(reference);
        }
    }
}
