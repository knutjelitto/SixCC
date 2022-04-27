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

            S8 = Add(new S8(this));
            S16 = Add(new S16(this));
            S32 = Add(new S32(this));
            S64 = Add(new S64(this));
            U8 = Add(new U8(this));
            U32 = TableIndex = Add(new U32(this));
            F32 = Add(new F32(this));
            F64 = Add(new F64(this));
            Anything = Add(new Anything(this));
            Boolean = Add(new Boolean(this));
            True = Add(new Boolean.True(this));
            False = Add(new Boolean.False(this));
            Bytes = Add(new Bytes(this));
            String = Add(new String(this));
            Address = Add(new Address(this));
            Builtin = Add(new BuiltinGeneric(this));
            Runtime = Add(new Runtime(this));
        }
        public Builtin TableIndex { get; }
        public Builtin Boolean { get; }
        public Builtin True { get; }
        public Builtin False { get; }
        public Builtin Bytes { get; }
        public Builtin String { get; }
        public Builtin Anything { get; }
        public Builtin Address { get; }
        public Builtin Builtin { get; }
        public Builtin Runtime { get; }

        public Builtin U8 { get; }
        public Builtin U32 { get; }

        public Builtin S8 { get; }
        public Builtin S16 { get; }
        public Builtin S32 { get; }
        public Builtin S64 { get; }

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
