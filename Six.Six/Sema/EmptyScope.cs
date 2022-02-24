using System;

namespace Six.Six.Sema
{
    public class EmptyScope : Scope
    {
        [DebuggerStepThrough]
        public EmptyScope(Scope parent)
        {
            Parent = parent;
        }
        public Scope Parent { get; }
        public IReadOnlyList<Member> Members { get; } = Array.Empty<Member>();
        public T Add<T>(T member) where T : Member => throw new NotImplementedException();
        public Decl? Resolve(string name) => Parent.Resolve(name);
        public Decl? Find(string name) => null;
    }
}
