using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public sealed record Using(IRNode Tree, Names Names, Using.ElementList Elements) : Declaration
    {
        public sealed record ElementList(IRNode Tree, IEnumerable<Element> Items)
            : Many<Element>(Tree, Items);

        public abstract record Element(IRNode Tree) : Node
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
