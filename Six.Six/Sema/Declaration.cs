using System.Collections;
using static Six.Six.Ast.Using.Element;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Declarations : IReadOnlyList<A.Decl>
    {
        private readonly List<A.Decl> items = new();
        private readonly List<A.TreeNode> usages = new();

        public Declarations(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Add(A.Decl declaration)
        {
            items.Add(declaration);
        }

        public void Use(A.TreeNode name)
        {
            usages.Add(name);
        }

        public A.Decl this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<A.Decl> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }
}
