using System.Collections;
using static Six.Six.Ast.Using.Element;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Declarations : IReadOnlyList<Declaration>
    {
        private readonly List<Declaration> items = new();
        private readonly List<A.TreeNode> usages = new();

        public Declarations(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Add(Declaration declaration)
        {
            items.Add(declaration);
        }

        public void Use(A.TreeNode name)
        {
            usages.Add(name);
        }

        public Declaration this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<Declaration> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }

    public interface Declaration : Entity, Type, WithName
    {
        public sealed record Function(A.Declaration.Function Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Infix(A.Declaration.Infix Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Prefix(A.Declaration.Prefix Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Class(A.Declaration.Class Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Attribute(A.Declaration.Attribute Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Object(A.Declaration.Object Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Interface(A.Declaration.Interface Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Alias(A.Declaration.Alias Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Parameter(A.Parameter Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record TypeParameter(A.Generic.TypeParameter Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Var(A.Declaration.Var Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Let(A.Declaration.Let Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record CTor(A.Declaration.Constructor Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Primitive(A.Declaration.Primitive Node, Container Container) : DeclarationImpl(Node, Container);
        public sealed record Any(A.Declaration Node, Container Container) : DeclarationImpl(Node, Container);

        public abstract record DeclarationImpl(A.With.Name Named, Container Container) : Declaration
        {
            public A.TreeNode Ast => Named;
            public A.Name Name => Named.Name;
        }
    }
}
