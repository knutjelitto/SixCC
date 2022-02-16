using Six.Core.Errors;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContainerCore : Container
    {
        private readonly Dictionary<string, Declarations> items = new();
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

        public IEnumerable<Declaration> GetDeclarations()
        {
            return items.Values.SelectMany(decls => decls);
        }

        public IEnumerable<Entity> GetAllEntities()
        {
            return children;
        }

        public Declarations Resolve(string name)
        {
            if (items.TryGetValue(name, out var declaration))
            {
                return declaration;
            }
            return Parent.Resolve(name);
        }

        public virtual Declarations Find(string name)
        {
            if (items.TryGetValue(name, out var declarations))
            {
                return declarations;
            }
            return new Declarations(name);
        }

        private void Declare(Declaration declaration)
        {
            if (!items.TryGetValue(declaration.Name, out var declarations))
            {
                declarations = new Declarations(declaration.Name);
                items.Add(declaration.Name, declarations);
            }
            declarations.Add(declaration);
        }

#if false
        private void DupError(Declaration named)
        {
            if (!items.TryGetValue(named.Name, out var already))
                throw new System.InvalidOperationException("--internal--");

            var diagnostic1 = new SemanticError(named.GetLocation(), $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            Module.Add(diagnostic1);
            Module.Add(diagnostic2);
        }
#endif
    }
}
