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

            buildins.Add(Module.Core.Int32, new S32(Resolver));
            var u32 = new U32(Resolver);
            buildins.Add(Module.Core.UInt32, u32);
            buildins.Add(Module.Core.Float32, new F32(Resolver));
            buildins.Add(Module.Core.Float64, new F64(Resolver));
            buildins.Add(Module.Core.Boolean, new Boolean(Resolver));

            TableIndex = u32;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

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
