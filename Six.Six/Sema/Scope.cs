using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Scope
    {
        Scope Parent { get; }
        string FullName { get; }
        public Module Module => Parent.Module;
        IReadOnlyList<Member> Members { get; }
        T AddMember<T>(T member, string? name = null) where T : Member;
        T Declare<T>(T decl, string? name = null) where T : Decl;
        Decl Resolve(A.TreeNode tree, string name);
        Decl Find(A.TreeNode tree, string name);
    }
}
