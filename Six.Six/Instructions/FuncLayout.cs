using Six.Runtime;
using Six.Six.Types;
using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Instructions
{
    public class FuncLayout
    {
        public readonly List<Decl.Local> Parameters = new();
        public readonly List<Decl.Local> Locals = new();

        public int AddParameter(Decl.Local parameter)
        {
            Assert(Locals.Count == 0);

            parameter.Index = Parameters.Count;

            Parameters.Add(parameter);

            return parameter.Index;
        }

        public int AddLocal(Decl.Local local)
        {
            local.Index = Parameters.Count + Locals.Count;

            Locals.Add(local);

            return local.Index;
        }

        private class LocalCore
        {
            protected LocalCore(int index)
            {
                Index = index;
            }

            public int Index { get; }
        }
    }
}
