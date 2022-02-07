using Six.Core.Errors;
using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public abstract class Scope : IScope
    {
        private readonly Dictionary<Name, INamed> items = new();

        public Scope(Global global)
        {
            Global = global;
        }

        public Global Global { get; }

        public void Declare(INamed named)
        {
            var added = items.TryAdd(named.Name, named);

            if (added)
            {
                Global.InScope(this, named);
            }
            else
            {
                DupError(named);
            }
        }

        public void ToResolve(Node node)
        {
            if (node is IResolveable resolveable)
            {
                Global.Add(this, resolveable);
            }
        }

        public IEnumerable<INamed> GetDeclarations()
        {
            return items.Values.OfType<INamed>().OrderBy(dc => dc.Name);
        }

        private void DupError(INamed item)
        {
            var already = items[item.Name]!;
            var diagnostic1 = new SemanticError(item.GetLocation(), $"identifier '{item.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            Global.Add(diagnostic1);
            Global.Add(diagnostic2);
        }
    }
}
