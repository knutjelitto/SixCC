using Six.Core;
using System;

using A = Six.Six.Ast;

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

        public virtual T DeclareContent<T>(T decl, string? name = null)
            where T : Decl
        {
            return Content.Declare<T>(decl, name);
        }

        public virtual T DeclareHead<T>(T decl, string? name = null)
            where T : Decl
        {
            return Head.Declare<T>(decl, name);
        }

        public virtual Decl? TryFind(string name)
        {
            var found = Content.TryFind(name);
            if (found == null)
            {
                found = Head.TryFind(name);
            }
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

        public override Decl? TryFind(string name)
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
