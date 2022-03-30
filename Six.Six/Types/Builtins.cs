using Six.Six.Sema;
using System;

namespace Six.Six.Types
{
    public class Builtins
    {
        private readonly Dictionary<string, BuiltinCore> buildins = new();

        public Builtins(Module module)
        {
            Module = module;

            S32 = Add(new S32(this));
            U32 = TableIndex = Add(new U32(this));
            F32 = Add(new F32(this));
            F64 = Add(new F64(this));
            Anything = Add(new Anything(this));
            Boolean = Add(new Boolean(this));
            Bytes = Add(new Bytes(this));
            String = Add(new String(this));
            Pointer = Add(new Pointer(this));
            Builtin = Add(new Builtin(this));
        }
        public BuiltinCore TableIndex { get; }
        public BuiltinCore Boolean { get; }
        public BuiltinCore Bytes { get; }
        public BuiltinCore String { get; }
        public BuiltinCore Anything { get; }
        public BuiltinCore Pointer { get; }
        public BuiltinCore Builtin { get; }

        public BuiltinCore U32 { get; }
        public BuiltinCore S32 { get; }

        public BuiltinCore F32 { get; }
        public BuiltinCore F64 { get; }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private BuiltinCore Add(BuiltinCore builtin)
        {
            buildins.Add(builtin.Name, builtin);
            return builtin;
        }

        public BuiltinCore Resolve(Decl named)
        {
            return Resolve(named.Name);
        }

        private BuiltinCore Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }
    }
}
