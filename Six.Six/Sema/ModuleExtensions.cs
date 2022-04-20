using Six.Six.Sema;

namespace Six.Six.Sema
{
    public static class ModuleExtensions
    {
        public static IEnumerable<Decl.Function> GetFunctions(this Module module)
        {
            return module.GetDeclarations().OfType<Decl.Function>();
        }

        public static IEnumerable<Decl.Global> GetGlobals(this Module module)
        {
            return module.GetDeclarations().OfType<Decl.Global>();
        }

        public static IEnumerable<Decl.Classy> GetClassies(this Module module)
        {
            return module.GetDeclarations().OfType<Decl.Classy>();
        }

        public static IEnumerable<Decl> GetDeclarations(this Module module)
        {
            foreach (var ns in module.GetNamespaces())
            {
                foreach (var decl in ns.GetDeclarations())
                {
                    yield return decl;
                }
            }
        }
    }
}