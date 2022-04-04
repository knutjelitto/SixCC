using Six.Six.Sema;
using System;

namespace Six.Six.Types
{
    public class Builtins
    {
        private readonly Dictionary<string, Builtin> buildins = new();

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
            Builtin = Add(new BuiltinGeneric(this));
        }
        public Builtin TableIndex { get; }
        public Builtin Boolean { get; }
        public Builtin Bytes { get; }
        public Builtin String { get; }
        public Builtin Anything { get; }
        public Builtin Pointer { get; }
        public Builtin Builtin { get; }

        public Builtin U32 { get; }
        public Builtin S32 { get; }

        public Builtin F32 { get; }
        public Builtin F64 { get; }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private Builtin Add(Builtin builtin)
        {
            buildins.Add(builtin.Name, builtin);
            return builtin;
        }

        public Builtin Resolve(Decl named)
        {
            return Resolve(named.Name);
        }

        private Builtin Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }
    }
}
