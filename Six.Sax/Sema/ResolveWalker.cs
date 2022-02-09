using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public sealed class ResolveWalker
    {
        public ResolveWalker(Module global)
        {
            Global = global;
        }

        public Module Global { get; }

        public void Walk(IResolveable node)
        {
            Visit(Global.ResolveIn[node], (dynamic)node);
        }

        private void Visit(IScope scope, TreeNode node)
        {
            Assert(true);
        }

        private void Visit(IScope scope, Reference node)
        {
            if (scope.TryFind(node.Name, out var found))
            {
                Assert(found != null);
            }
            else
            {
                Assert(false);
            }
        }
    }
}
