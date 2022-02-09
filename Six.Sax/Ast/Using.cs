using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public sealed record Using(IRNode Tree, Names Names, Using.ElementList Elements) : TreeNode
    {
        public sealed record ElementList(IRNode Tree, IEnumerable<Element> Items)
            : Many<Element>(Tree, Items);

        public abstract record Element(IRNode Tree) : TreeNode
        {
            public sealed record Named(IRNode Tree, Name Name, Name? Alias, ElementList? Elements)
                : Element(Tree);
            public sealed record Wildcard(IRNode Tree)
                : Element(Tree);
        }

        public sealed record Usings(IRNode Tree, IEnumerable<Using> Items)
            : Many<Using>(Tree, Items);
    }
}
