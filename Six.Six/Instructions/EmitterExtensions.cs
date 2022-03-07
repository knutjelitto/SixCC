using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public static class EmitterExtensions
    {
        public static IEnumerable<Decl.Function> GetFunctions(this Module module)
        {
            foreach (var ns in module.GetNamespaces())
            {
                foreach (var decl in ns.GetDeclarations())
                {
                    if (decl is Decl.Function function)
                    {
                        yield return function;
                    }
                }
            }
        }
    }
}