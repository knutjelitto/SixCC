using System;

using Six.Runtime;
using Six.Six.Types;
using Six.Six.Sema;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Sema
{
    public class FuncMembers
    {
        public readonly List<Decl.Local> parameters = new();
        public readonly List<Decl.Local> locals = new();
        public readonly List<Decl.Funcy> functions = new();

        public IEnumerable<Decl> GetAll() => Functions.Cast<Decl>();

        public IReadOnlyList<Decl.Local> Parameters => parameters;
        public IReadOnlyList<Decl.Local> Locals => locals;
        public IReadOnlyList<Decl.Funcy> Functions => functions;

        public int AddParameter(Decl.Local parameter)
        {
            Assert(Locals.Count == 0);

            parameter.Index = parameters.Count;

            parameters.Add(parameter);

            return parameter.Index;
        }

        public int AddLocal(Decl.Local local)
        {
            local.Index = parameters.Count + locals.Count;

            locals.Add(local);

            return local.Index;
        }

        public void AddFunction(Decl.Funcy function)
        {
            functions.Add(function);
        }
    }
}
