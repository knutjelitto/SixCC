using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Six.Six.Instructions;

namespace Six.Six.Builtins
{
    public abstract class Xnn<TInsn,TValue> : Builtin
        where TInsn : Insn.Xnn<TValue>
        where TValue : struct
    {
        protected Xnn(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
