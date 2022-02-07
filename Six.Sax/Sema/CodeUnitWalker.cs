using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class CodeUnitWalker
    {
        private CodeUnitWalker(Global global, NamespaceScope scope)
        {
            Global = global;
            Into = scope;
        }

        public Global Global { get; }
        public NamespaceScope Into { get; }

        public static void Walk(Global global, Unit.Code code)
        {
            var scope = global.Open(code.Namespace.Select(n => n.Text));

            var walker = new CodeUnitWalker(global, scope);

            walker.Walk(code);
        }

        private void Walk(Unit.Code code)
        {
            foreach (var declaration in code.Declarations)
            {
                Walk(Into, declaration);
            }
        }

        private void Walk(IScope into, Node? node)
        {
            if (node != null)
            {
                Visit(into, (dynamic)node);
            }
        }

        private void WalkMany(IScope into, IEnumerable<Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(into, node);
                }
            }
        }

        private void Visit(IScope into, Node node)
        {
            Assert(false);
        }

        private void Visit(IScope into, Declaration.Entity.Impl node)
        {
            into.Declare(node);

            var ds = new DeclarationScope(into);

            WalkMany(ds, node.Generics);
            WalkMany(ds, node.Parameters);
        }

        private void Visit(IScope into, Declaration.Entity.Class node)
        {
            into.Declare(node);
        }

        private void Visit(IScope into, Parameter node)
        {
            into.Declare(node);
            into.ToResolve(node.Type);
        }

        private void Visit(IScope into, Generic.Parameter node)
        {
            into.Declare(node);
        }
    }
}
