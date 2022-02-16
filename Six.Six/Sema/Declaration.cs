using System.Collections;
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

    public interface Declaration : Entity, Named
    {
        public A.Name Name =>  ((A.With.Name)Ast).Name;

        public sealed record Function(A.With.Name Named, Container Container) : DeclarationImpl(Named, Container);
        public sealed record Infix(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Prefix(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Class(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Attribute(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Object(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Interface(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Alias(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Parameter(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record TypeParameter(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Var(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Let(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record CTor(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Primitive(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Any(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);

        public abstract record DeclarationImpl(A.TreeNode Ast, Container Container) : Declaration
        {
            public override string ToString()
            {
                return $"{GetType().Name} {((Declaration)this).Name}";
            }
        }

    }
}
