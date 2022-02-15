using Six.Core.Errors;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContainerCore : Container
    {
        private readonly Dictionary<string, Declaration> items = new();
        private readonly List<Entity> children = new();

        public ContainerCore(Container parent)
        {
            Parent = parent;
        }

        public Module Module => Parent.Module;
        public Container Parent { get; }

        public IReadOnlyList<Entity> Children => children;

        public Entity AddChild(Entity entity)
        {
            children.Add(entity);

            if (entity is Declaration declaration)
            {
                Declare(declaration);
            }

            return entity;
        }

        public IEnumerable<Entity> GetAllEntities()
        {
            return children;
        }

        public Declaration? Resolve(string name)
        {
            if (items.TryGetValue(name, out var entity))
            {
                return entity;
            }
            return Parent.Resolve(name);
        }

        public virtual Declaration? Find(string name)
        {
            if (items.TryGetValue(name, out var entity))
            {
                return entity;
            }
            return null;
        }

        public virtual bool TryFind(A.Name name, [MaybeNullWhen(false)] out Declaration? entity)
        {
            return items.TryGetValue(name.Text, out entity);
        }

        private void Declare(Declaration declaration)
        {
            if (!items.TryAdd(declaration.Name, declaration))
            {
                DupError(declaration);
            }
        }

        private void DupError(Declaration named)
        {
            if (!items.TryGetValue(named.Name, out var already))
                throw new System.InvalidOperationException("--internal--");

            var diagnostic1 = new SemanticError(named.GetLocation(), $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            Module.Add(diagnostic1);
            Module.Add(diagnostic2);
        }
    }
}
