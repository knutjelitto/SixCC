using Six.Sax.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void Visit(IScope into, Node node)
        {
        }

        private void Visit(IScope into, Declaration.Entity node)
        {
            //TODO: remove
            Dc.Declare(into, node);
        }

        private void Visit(IScope into, Declaration.Entity.Class node)
        {
            Dc.Declare(into, node);

            var ds = new DeclarationScope(into);

            Walk(ds, node.Parameters);
        }

        private void Visit(IScope into, Parameters node)
        {
            foreach (var parameter in node)
            {
                Walk(into, parameter);
            }
        }

        private void Visit(IScope into, Parameter node)
        {
        }
    }
}
