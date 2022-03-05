using Six.Core;
using Six.Runtime;
using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Location
    {
        public static ILocation From(A.TreeNode node)
        {
            if (node is A.With.Name named)
            {
                return From(named.Name.Tree);
            }
            return From(node.Tree);
        }

        public static ILocation From(IRNode node)
        {
            if (node is IRLocated token)
            {
                return new RuntimeLocation(token.Source, token.Core, token.End - token.Core);
            }

            Assert(node.Children.Length > 0);

            return From(node.Children[0]);
        }
    }
}
