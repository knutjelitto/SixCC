using System;

namespace Six.Six.Sema
{
    public interface Body
    {
        public record Expression(Func<Expr> Resolver) : Body
        {
            private Expr? concrete;
            public Expr Expr => concrete ??= Resolver();
        }

        public record Dummy() : Body
        {
        }
    }

    public abstract class Block : Body
    {
        protected Block(string name, Scope parent)
        {
            Scope = new BlockScope(name, parent);
        }

        public BlockScope Scope { get; }
        public List<Member> Members { get; } = new();
    }

    public class ClassBlock : Block
    {
        public ClassBlock(Decl.Classy classy, Scope parent)
            : base(classy.ADecl.Name.Text, parent)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
    }

    public class CodeBlock : Block
    {
        public CodeBlock(Decl.Funcy funcy, Scope parent)
            : base(funcy.ADecl.Name.Text, parent)
        {
            Funcy = funcy;
        }

        public Decl.Funcy Funcy { get; }
    }

    public class NamespaceBlock : Block
    {
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public NamespaceBlock(string name, Scope parent)
            : base(name, parent)
        {
        }
    }

    public class ModuleBlock : Block
    {
        public readonly Dictionary<string, NamespaceBlock> Children = new();

        public ModuleBlock(string name, Scope parent)
            : base(name, parent)
        {
        }

    }
}
