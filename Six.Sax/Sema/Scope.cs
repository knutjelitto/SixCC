using Six.Core.Errors;
using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public abstract class Scope : IScope, Container
    {
        private readonly Dictionary<A.Name, A.With.Name> items = new();
        private readonly List<Entity> entities = new();

        public Scope(Module module)
        {
            Module = module;
        }

        public Module Module { get; }

        public IReadOnlyList<Entity> Entities => entities;

        public void Add(Entity entity)
        {
            entities.Add(entity);
        }

        public virtual bool TryFind(A.Name name, [MaybeNullWhen(false)] out A.With.Name? node)
        {
            return items.TryGetValue(name, out node);
        }

        public IEnumerable<Declaration> GetDeclarations()
        {
            return entities.OfType<Declaration>();
        }

        private void DupError(A.With.Name item)
        {
            var already = items[item.Name]!;
            var diagnostic1 = new SemanticError(item.GetLocation(), $"identifier '{item.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            Module.Add(diagnostic1);
            Module.Add(diagnostic2);
        }
    }
}
