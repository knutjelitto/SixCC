using Six.Core;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    [DebuggerDisplay("scope {FullName}")]
    public abstract class ScopeCore : Scope
    {
        private readonly Dictionary<string, Decl> declarations = new();

        [DebuggerStepThrough]
        public ScopeCore(Module module, Scope parent, string name)
        {
            Name = name;
            Module = module;
            Parent = parent;
        }

        public Module Module { get; }
        public Errors Errors => Module.Errors;

        public string Name { get; }
        public Scope Parent { get; }

        public virtual Decl? TryFind(string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }

            return null;
        }

        public Decl Resolve(A.TreeNode tree, string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }
            if (Parent is Module module)
            {
                throw Errors.CantResolve(tree, name);
            }

            return Parent.Resolve(tree, name);
        }

        public T Declare<T>(T decl, string? name = null) where T : Decl
        {
            name ??= decl.Name;

            if (declarations.TryGetValue(name, out var already))
            {
                throw Errors.DupError(decl, already);
            }
            declarations.Add(name, decl);

            return decl;
        }
    }
}
