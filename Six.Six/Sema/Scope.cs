using Six.Core;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    [DebuggerDisplay("scope {FullName}")]
    public class Scope
    {
        private readonly Dictionary<string, Decl> declarations = new();

        [DebuggerStepThrough]
        public Scope(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        private Errors Errors => Module.Errors;

        public virtual Decl? TryFind(string name)
        {
            if (declarations.TryGetValue(name, out var decl))
            {
                return decl;
            }

            return null;
        }

        public T Declare<T>(T decl) where T : Decl
        {
            var name = decl.Name;

            if (declarations.TryGetValue(name, out var already))
            {
                throw Errors.DupError(decl, already);
            }
            declarations.Add(name, decl);

            return decl;
        }
    }
}
