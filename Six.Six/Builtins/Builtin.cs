using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public sealed class Builtin : BuiltinCore
    {
        public Builtin(Builtins builtins)
            : base(builtins, Names.Core.Builtin, WasmDef.Pointer)
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
