using System;

using Six.Six.Instructions;
using Six.Six.Sema;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class Anything : Builtin
    {
        public Anything(Builtins builtins)
            : base(builtins, Names.Core.Anything, W.WasmType.Addr)
        { }

        public override Insn Load(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        public override Insn Store(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        public override string ToString() => Name;
    }
}
