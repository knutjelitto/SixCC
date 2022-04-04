using Six.Six.Instructions;
using Six.Six.Sema;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class BuiltinGeneric : Builtin
    {
        public BuiltinGeneric(Builtins builtins)
            : base(builtins, Names.Core.Builtin, W.WasmType.Addr)
        {
        }

        public override Insn Load(uint offset)
        {
            Assert(false);
            throw new System.NotImplementedException();
        }

        public override Insn Store(uint offset)
        {
            Assert(false);
            throw new System.NotImplementedException();
        }
    }
}
