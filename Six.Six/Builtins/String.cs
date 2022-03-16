using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public sealed class String : Builtin
    {
        public String(Builtins builtins)
            : base(builtins, Names.Core.String, WasmDef.Pointer)
        { }

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
