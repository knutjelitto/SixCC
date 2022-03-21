using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public struct Ptr
    {
        public Ptr(uint value)
        {
            Value = value;
        }

        public uint Value { get; }

        public Insn Insn => Insn.U32.Const(Value);
    }
}
