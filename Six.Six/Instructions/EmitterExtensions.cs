using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public static class EmitterExtensions
    {
        public static IEnumerable<Decl.Function> GetFunctions(this Module module)
        {
            return module.GetDeclarations().OfType<Decl.Function>();
        }

        public static IEnumerable<Member> GetMembers(this Module module)
        {
            return
                module.GetDeclarations().OfType<Decl.Class>().Cast<Decl.Classy>()
                .Concat(module.GetDeclarations().OfType<Decl.Interface>())
                .Concat(module.GetDeclarations().OfType<Decl.Primitive>())
                .Concat(module.GetDeclarations().OfType<Decl.Object>())
                .SelectMany(cls => cls.Members);
        }

        public static IEnumerable<Decl.Classy> GetClassies(this Module module)
        {
            return module.GetDeclarations().OfType<Decl.Classy>();
        }

        public static IEnumerable<Decl.Function> GetMethods(this Module module)
        {
            return module.GetMembers().OfType<Decl.Function>();
        }

        public static IEnumerable<Decl.Constructor> GetConstructors(this Module module)
        {
            return module.GetMembers().OfType<Decl.Constructor>();
        }

        public static IEnumerable<Decl.Attribute> GetAttributes(this Module module)
        {
            return module.GetMembers().OfType<Decl.Attribute>();
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