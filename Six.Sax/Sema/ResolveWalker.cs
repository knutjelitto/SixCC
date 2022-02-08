using Six.Sax.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Sema
{
    public sealed class ResolveWalker
    {
        public ResolveWalker(Global global)
        {
            Global = global;
        }

        public Global Global { get; }

        public void Walk(IResolveable node)
        {
            Visit(Global.ResolveIn[node], (dynamic)node);
        }

        private void Visit(IScope scope, Node node)
        {
            Assert(false);
        }

        private void Visit(IScope scope, Reference node)
        {
            if (scope.TryFind(node.Name, out var found))
            {
                Assert(found != null);
                Global.ResolvedTo.Add(node.Name, found);
            }
            else
            {
                Assert(false);
            }
        }
    }
}
