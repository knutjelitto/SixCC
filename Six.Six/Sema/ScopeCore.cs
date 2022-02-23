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
        public ScopeCore(Scope parent)
        {
            Parent = parent;
        }

        public Module Module => Parent.Module;
        public Scope Parent { get; }

        public IReadOnlyList<Member> Members => members;

        public IEnumerable<Decl> GetDeclarations()
        {
            return declarations.Values;
        }

        public virtual Decl? Find(string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }
            return null;
        }

        public Decl? Resolve(string name)
        {
            if (declarations.TryGetValue(name, out var decl))
                {
                return decl;
            }
            return Parent.Resolve(name);
        }

        public T Add<T>(T member) where T : Member
        {
            if (member is Decl decl)
            {
                if (declarations.ContainsKey(decl.Name.Text))
                {
                    DupError(decl);
                }
                else
                {
                    declarations[decl.Name.Text] = decl;
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
