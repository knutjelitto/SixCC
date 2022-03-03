using Six.Core.Errors;
using Six.Runtime.Types;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public abstract class ScopeCore : Scope
    {
        private readonly Dictionary<string, Decl> declarations = new();
        private readonly List<Member> members = new();

        [DebuggerStepThrough]
        public ScopeCore(string name, Scope parent)
        {
            Name = name;
            Parent = parent;
        }

        public Module Module => Parent.Module;

        public string Name { get; }
        public Scope Parent { get; }

        public virtual string FullName
        {
            get
            {
                var full = Parent.FullName;
                if (full == "")
                {
                    return $"{Name}";
                }
                return $"{full}.{Name}";
            }
        }
        public IReadOnlyList<Member> Members => members;
        public IEnumerable<Decl> GetDeclarations()
        {
            return declarations.Values;
        }

        public virtual Decl Find(A.TreeNode tree, string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }

            throw new DiagnosticException(
                new SemanticError(tree.GetLocation(), $"can't find ``{tree}´´"));
        }

        public Decl Resolve(A.TreeNode tree, string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }
            if (Parent is Module)
            {
                throw new DiagnosticException(
                    new SemanticError(tree.GetLocation(), $"can't find ``{tree}´´"));
            }

            return Parent.Resolve(tree, name);
        }

        public T AddMember<T>(T member, string? name = null) where T : Member
        {
            if (member is Decl decl)
            {
                name ??= decl.Name.Text;
                if (declarations.ContainsKey(name))
                {
                    DupError(decl);
                }
                else
                {
                    declarations[name] = decl;
                }
            }
            members.Add(member);

            return member;
        }
        
        private void DupError(Decl named)
        {
            if (!declarations.TryGetValue(named.Name.Text, out var already))
                throw new System.InvalidOperationException("--internal--");

            var diagnostic1 = new SemanticError(named.ADecl.GetLocation(), $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.ADecl.GetLocation(), $"identifier '{already.Name}' introduced here");

            Module.Add(diagnostic1);
            Module.Add(diagnostic2);
        }
    }
}
