﻿using System;

using A = Six.Six.Ast;

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
        public string FullName => $"{Parent.FullName}";
        public IReadOnlyList<Member> Members { get; } = Array.Empty<Member>();
        public T AddMember<T>(T member, string? name) where T : Member => throw new NotImplementedException();
        public T Declare<T>(T decl, string? name = null) where T : Decl => throw new NotImplementedException();
        public Decl Resolve(A.TreeNode tree, string name) => Parent.Resolve(tree, name);
        public Decl Find(A.TreeNode tree, string name) => throw new NotImplementedException();
    }
}
