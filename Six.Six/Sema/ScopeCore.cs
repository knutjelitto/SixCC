﻿using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    [DebuggerDisplay("scope {FullName}")]
    public abstract class ScopeCore : Scope
    {
        private readonly Dictionary<string, Decl> declarations = new();

        [DebuggerStepThrough]
        public ScopeCore(Scope parent, string name)
        {
            Name = name;
            Parent = parent;
        }

        public Module Module => Parent.Module;
        public Resolver Resolver => Module.Resolver;
        public Errors Errors => Module.Errors;

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

            throw Errors.CantResolve(tree, name);
        }

        public Decl Resolve(A.TreeNode tree, string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }
            if (Parent is Module)
            {
                throw Errors.CantResolve(tree, name);
            }

            return Parent.Resolve(tree, name);
        }

        public T Declare<T>(T decl, string? name = null) where T : Decl
        {
            name ??= decl.Name.Text;

            if (declarations.TryGetValue(name, out var already))
            {
                throw Errors.DupError(decl, already);
            }
            declarations.Add(name, decl);

            return decl;
        }
    }
}
