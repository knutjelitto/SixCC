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
            U16 = Add(new U16(this));
            U32 = Add(new U32(this));
            U64 = Add(new U64(this));
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

        public Builtin Boolean { get; }
        public Builtin True { get; }
        public Builtin False { get; }
        public Builtin Bytes { get; }
        public Builtin String { get; }
        public Builtin Anything { get; }
        public Builtin Address { get; }
        public Builtin Builtin { get; }
        public Builtin Runtime { get; }

        public U8 U8 { get; }
        public U16 U16 { get; }
        public U32 U32 { get; }
        public U64 U64 { get; }

        public S8 S8 { get; }
        public S16 S16 { get; }
        public S32 S32 { get; }
        public S64 S64 { get; }

        public F32 F32 { get; }
        public F64 F64 { get; }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private T Add<T>(T builtin)
            where T : Builtin
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
