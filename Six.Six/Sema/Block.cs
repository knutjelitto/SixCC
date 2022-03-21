﻿using System;

namespace Six.Six.Sema
{
    [DebuggerDisplay("{GetType().Name} {Name}")]
    public abstract class Block
    {
        private BlockScope? content;
        private BlockScope? head;

        protected Block(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract Block Parent { get; }
        public virtual BlockScope Content => content ??= new BlockScope(Name, Head);
        public virtual BlockScope Head => head ??= new BlockScope(Name, Parent.Content);
        public List<Member> Members { get; } = new();
    }

    public class ClassBlock : Block
    {
        public ClassBlock(Decl.Classy classy, Block parent)
            : base(classy.ADecl.Name.Text)
        {
            Classy = classy;
            Parent = parent;
        }

        public Decl.Classy Classy { get; }

        public override Block Parent { get; }
    }

    public class FuncBlock : Block
    {
        public FuncBlock(Decl.Funcy funcy, Block parent, string? name = null)
            : base(name ?? funcy.ADecl.Name.Text)
        {
            Funcy = funcy;
            Parent = parent;
        }

        public Decl.Funcy Funcy { get; }

        public override Block Parent { get; }
    }

    public class NamespaceBlock : Block
    {
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public NamespaceBlock(string name, Block parent)
            : base(name)
        {
            Parent = parent;
        }

        public override Block Parent { get; }

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
    }

    public class ModuleBlock : Block
    {
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public ModuleBlock(Module module, string name)
            : base(name)
        {
            Head = new BlockScope(name, new EmptyScope(module));
            Content = new BlockScope(name, Head);
        }

        public override BlockScope Head { get; }
        public override BlockScope Content { get; }
        public override Block Parent => throw new InvalidOperationException();
    }
}
