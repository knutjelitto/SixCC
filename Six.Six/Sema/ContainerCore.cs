using Six.Core.Errors;
using Six.Runtime.Types;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContainerCore : Container
    {
        private readonly Dictionary<string, A.Decl> items = new();
        private readonly List<A.TreeNode> children = new();

        [DebuggerStepThrough]
        public ContainerCore(Container parent)
        {
            Parent = parent;
        }

        public Module Module => Parent.Module;
        public Container Parent { get; }

        public IReadOnlyList<A.TreeNode> Children => children;

        [DebuggerStepThrough]
        public T AddChild<T>(T entity) where T: A.TreeNode
        {
            children.Add(entity);

            if (entity is A.Decl declaration)
            {
                Declare(declaration);
            }

            return entity;
        }

        public IEnumerable<A.Decl> GetDeclarations()
        {
            return items.Values;
        }

        public IEnumerable<A.TreeNode> GetAllEntities()
        {
            return children;
        }

        public virtual A.Decl? Resolve(A.Reference reference)
        {
            if (items.TryGetValue(reference.Name.Text, out var decl))
            {
                return decl;
            }
            return Parent.Resolve(reference);
        }

        public virtual A.Decl? Find(string name)
        {
            if (items.TryGetValue(name, out var decl))
            {
                return decl;
            }
            return null;
        }

        private void Declare(A.Decl decl)
        {
            if (items.ContainsKey(decl.Name.Text))
            {
                DupError(decl);
            }
            else
            {
                items[decl.Name.Text] = decl;
            }
        }
        
        private void DupError(A.Decl named)
        {
            if (!items.TryGetValue(named.Name.Text, out var already))
                throw new System.InvalidOperationException("--internal--");

            var diagnostic1 = new SemanticError(named.GetLocation(), $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            Module.Add(diagnostic1);
            Module.Add(diagnostic2);
        }
    }
}
