using Six.Ceylon.Ast;
using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Visitor
{
    internal static class CeylonVisitorExtensions
    {
        public static Identifier GetId(this IRNode node)
        {
            return node.GetValue<Identifier>() ?? throw new NullReferenceException("can't get identifier from node");
        }
    }
}
