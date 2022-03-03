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

            buildins.Add(Module.Core.Int32, new S32());
            buildins.Add(Module.Core.UInt32, new U32());
            buildins.Add(Module.Core.Float64, new F64());
        }

        public Module Module { get; }

        public Builtin Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new NotImplementedException();
        }
    }
}
