using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Anything : BuiltinCore
    {
        public Anything(Builtins builtins)
            : base(builtins, Names.Core.Anything, WasmDef.Pointer)
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
