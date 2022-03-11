using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class Builtins
    {
        private readonly Dictionary<string, Builtin> buildins = new();

        public Builtins(Module module)
        {
            Module = module;

            Add(new S32());
            var u32 = Add(new U32());
            Add(new F32());
            Add(new F64());
            Add(new Anything());
            Add(new Boolean());

            TableIndex = u32;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private Builtin Add(Builtin builtin)
        {
            buildins.Add(builtin.Name, builtin);
            return builtin;
        }

        public Builtin TableIndex { get; }

        public Builtin Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }
    }
}
