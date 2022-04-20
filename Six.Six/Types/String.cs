using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class String : Builtin
    {
        public String(Builtins builtins)
            : base(builtins, Names.Core.String, WasmType.Addr)
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
