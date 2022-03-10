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

            Add(Module.Core.Int32, new S32());
            var u32 = Add(Module.Core.UInt32, new U32());
            Add(Module.Core.Float32, new F32());
            Add(Module.Core.Float64, new F64());
            Add(Module.Core.Anything, new Anything());
            Add(Module.Core.Boolean, new Boolean());

            TableIndex = u32;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private Builtin Add(string name, Builtin builtin)
        {
            buildins.Add(name, builtin);
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
