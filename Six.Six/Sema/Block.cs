using System;

namespace Six.Six.Sema
{
    [DebuggerDisplay("{GetType().Name} {Name}")]
    public abstract class Block
    {
        private BlockScope? content;
        private BlockScope? head;

        protected Block(Module module, string name)
        {
            Module = module;
            Name = name;
        }

        public Module Module { get; }
        public string Name { get; }
        public abstract Block Parent { get; }
        public virtual BlockScope Content => content ??= new BlockScope(Module, Name, Head);
        public virtual BlockScope Head => head ??= new BlockScope(Module, Name, Parent.Content);
        public Resolver Resolver => Module.Resolver;
        public List<Member> Members { get; } = new();
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

    public sealed class ContentBlock : LinkedBlock
    {
        public ContentBlock(Block parent, string name) : base(parent, name)
        {
        }
    }

    public sealed class HeadBlock : LinkedBlock
    {
        public HeadBlock(Block parent, string name) : base(parent, name)
        {
        }
    }

    public sealed class ClassBlock : LinkedBlock
    {
        public ClassBlock(Block parent, Decl.Classy classy)
            : base(parent, classy.Name)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
    }

    public sealed class FuncBlock : LinkedBlock
    {
        public FuncBlock(Block parent, Decl.Funcy funcy, string? name = null)
            : base(parent, name ?? funcy.Name)
        {
            Funcy = funcy;
        }

        public Decl.Funcy Funcy { get; }
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
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public NamespaceBlock(Block parent, string name)
            : base(parent, name)
        {
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
    }

    public class ModuleBlock : Block
    {
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public ModuleBlock(Module module, string name)
            : base(module, name)
        {
            Head = new BlockScope(module, name, new EmptyScope(module));
            Content = new BlockScope(module, name, Head);
        }

        public override BlockScope Head { get; }
        public override BlockScope Content { get; }
        public override Block Parent => throw new InvalidOperationException();
    }
}
