using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Scope
    {
        Scope Parent { get; }
        public Module Module => Parent.Module;
        IReadOnlyList<Member> Members { get; }
        T AddMember<T>(T member) where T : Member;
        Decl? Resolve(string name);
        Decl? Find(string name);
    }
}
