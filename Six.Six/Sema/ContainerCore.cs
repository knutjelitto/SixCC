using Six.Core.Errors;
using Six.Runtime.Types;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ContainerCore : Container
    {
        private readonly Dictionary<string, Declarations> items = new();
        private readonly List<A.TreeNode> children = new();

        public ContainerCore(Container parent)
        {
            Parent = parent;
        }

        public Module Module => Parent.Module;
        public Container Parent { get; }

        public IReadOnlyList<A.TreeNode> Children => children;

        public T AddChild<T>(T entity) where T: A.TreeNode
        {
            children.Add(entity);

            if (entity is A.Decl declaration)
            {
                Declare(declaration);
            }

            return entity;
        }

        public IEnumerable<Declarations> GetDeclarations()
        {
            return items.Values;
        }

        public IEnumerable<A.Decl> GetDeclarationsFlat()
        {
            return items.Values.SelectMany(decls => decls);
        }

        public IEnumerable<A.TreeNode> GetAllEntities()
        {
            return children;
        }

        public virtual Declarations Resolve(A.Reference reference)
        {
            if (items.TryGetValue(reference.Name.Text, out var declaration))
            {
                return declaration;
            }
            return Parent.Resolve(reference);
        }

        public virtual Declarations Find(A.TreeNode usage, string name)
        {
            if (!items.TryGetValue(name, out var declarations))
            {
                declarations = new Declarations(name);
                items.Add(name, declarations);
            }
            declarations.Use(usage);
            return declarations;
        }

        private void Declare(A.Decl declaration)
        {
            if (declaration.Name.Text == "_+_")
            {
                Assert(true);
            }
            if (!items.TryGetValue(declaration.Name.Text, out var declarations))
            {
                declarations = new Declarations(declaration.Name.Text);
                items.Add(declaration.Name.Text, declarations);
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
