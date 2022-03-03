using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wasmtime;

using S = Six.Six.Sema;

namespace Six.Six
{
    public class Wasm
    {
        public void Run(S.Module smodule)
        {
            var wat = smodule.Emit();

            using var engine = new Engine();
            using var module = Module.FromText(engine, "six", wat);
            using var linker = new Linker(engine);
            using var store = new Store(engine);

            var instance = linker.Instantiate(store, module);

            var function = instance.GetFunction(store, "six.tests.result_with_consts");

            if (function == null)
            {
                Console.WriteLine("error: function export is missing");
                return;
            }

            var x = function.Invoke(store, (int)42);
        }
    }
}
