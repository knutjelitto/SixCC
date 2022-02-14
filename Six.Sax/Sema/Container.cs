using A = Six.Sax.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Sema
{
    public interface Container
    {
        Container Parent { get; }
        public Module Module => Parent.Module;
        IReadOnlyList<Entity> Children { get; }
        Entity AddChild(Entity entity);
        Declaration? Resolve(string name);

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
            public Declaration? Resolve(string name) => Parent.Resolve(name);
        }
    }
}
