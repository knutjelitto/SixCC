using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class Terminal : Node
    {
        public Terminal(ITerminalNode node, IEnumerable<IToken>? spaceBefore)
        {
            Node = node;
            SpaceBefore = (spaceBefore ?? Enumerable.Empty<IToken>()).ToList();
        }

        public ITerminalNode Node { get; }
        public List<IToken> SpaceBefore { get; }

        public override string ToString()
        {
            return Node.GetText();
        }
    }
}
