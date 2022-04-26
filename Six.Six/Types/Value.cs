using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Value : Builtin
    {
        protected Value(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
