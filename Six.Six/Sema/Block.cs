﻿using Six.Core;
using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    [DebuggerDisplay("{GetType().Name} {Name}")]
    public abstract class Block
    {
        private Scope? content;

        protected Block(Module module, string name)
        {
            Module = module;
            Name = name;
        }

        public Module Module { get; }
        public string Name { get; }
        public abstract Block Parent { get; }
        public Errors Errors => Module.Errors;
        public virtual Scope Content => content ??= new Scope(Module);
        public Resolver Resolver => Module.Resolver;

        public virtual T Declare<T>(T decl)
            where T : Decl
        {
            return Content.Declare<T>(decl);
        }

        protected virtual Decl? TryFind(string name)
        {
            var found = Content.TryFind(name);
            return found;
        }

        public virtual T Find<T>(ILocation location, string name)
            where T : Decl
        {
            var found = Content.TryFind(name);
            if (found is T foundAsT)
            {
                return foundAsT;
            }
            throw Module.Errors.CantResolveMember(location, name);
        }

        public virtual Decl Resolve(ILocation location, string name)
        {
            var found = TryFind(name);
            if (found == null)
            {
                if (Parent is ModuleBlock)
                {
                    throw Module.Errors.CantResolveMember(location, name);
                }
                return Parent.Resolve(location, name);
            }
            return found;
        }

        public virtual Decl Resolve(A.Reference reference, string? name = null)
        {
            return Resolve(reference.GetLocation(), name ?? reference.Name.Text);
        }
    }

    public abstract class LinkedBlock : Block
    {
        protected LinkedBlock(Block parent, string name)
            : base(parent.Module, name)
        {
            Parent = parent;
        }

        public override Block Parent { get; }
    }

    public sealed class ClassBlock : LinkedBlock
    {
        public ClassBlock(Block parent, Decl.Classy classy)
            : base(parent, classy.Name)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }

        protected override Decl? TryFind(string name)
        {
            var found = base.TryFind(name);
            if (found == null && Classy.Extends != null)
            {
                found = Classy.Extends.Block.TryFind(name);
            }
            return found;
        }
    }

    public sealed class FuncBlock : LinkedBlock
    {
        public FuncBlock(Block parent, Decl.Funcy funcy, string? name = null)
            : base(parent, name ?? funcy.Name)
        {
            Funcy = funcy;
            CodeBlock = new CodeBlock(this, funcy, name ?? funcy.Name);
        }

        public Decl.Funcy Funcy { get; }
        public CodeBlock CodeBlock { get; }
    }

    public sealed class CodeBlock : LinkedBlock
    {
        public CodeBlock(Block parent, Decl.Funcy funcy, string name)
            : base(parent, name)
        {
            Funcy = funcy;
        }

        public Decl.Funcy Funcy { get; }
        public List<Stmt> Stmts { get; } = new();
        public Type StmtsType
        { 
            get
            {
                Type type = new Type.Void(Module);
                foreach (var stmt in Stmts)
                {
                    type = stmt.Type;
                    if (stmt is Stmt.Return)
                    {
                        break;
                    }
                }
                return type;
            }
        }

        public void Add(Stmt stmt)
        {
            Stmts.Add(stmt);
        }

        public CodeBlock NewNested()
        {
            return new CodeBlock(this, Funcy, Name);
        }
    }

    public sealed class FileBlock : LinkedBlock
    {
        public FileBlock(Block parent, string name)
            : base(parent, name)
        {
        }
    }

    public sealed class NamespaceBlock : LinkedBlock
    {
        private readonly List<Member> members = new();
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public NamespaceBlock(Block parent, string name)
            : base(parent, name)
        {
        }

        public IReadOnlyList<Member> Members => members;

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public NamespaceBlock? Get(string name)
        {
            if (Children.TryGetValue(name, out var block))
            {
                return block;
            }
            return null;
        }

        public IEnumerable<NamespaceBlock> GetNamespaces()
        {
            foreach (var child in Children.Values)
            {
                yield return child;
                foreach (var childchild in child.GetNamespaces())
                {
                    yield return childchild;
                }
            }
        }

        public string GetPath()
        {
            if (Parent is NamespaceBlock parent)
            {
                return (parent.GetPath() + "." + Name).TrimStart('.');
            }
            else
            {
                return "";
            }
        }

        public Decl? TryFind2(string name)
        {
            var found = Content.TryFind(name);
            return found;
        }
    }

    public class ModuleBlock : Block
    {
        public ModuleBlock(Module module, string name)
            : base(module, name)
        {
            Content = new Scope(module);
        }

        public override Scope Content { get; }
        public override Block Parent => throw new InvalidOperationException();
    }
}
