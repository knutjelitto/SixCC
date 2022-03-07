using System;

using Wasmtime;

using S = Six.Six.Sema;

namespace Six.Six
{
    public class Wasmtime
    {
        public void Run(S.Module smodule)
        {
            if (smodule.Errors)
            {
                return;
            }

            var wat = smodule.Emit();

            using var engine = new Engine();
            using var module = Module.FromText(engine, "six", wat);
            using var linker = new Linker(engine);
            using var store = new Store(engine);

            var instance = linker.Instantiate(store, module);

            var v48 = GetFunction(store, instance, "six.result_with_consts").Invoke(store, 42);

            var v5 = GetFunction(store, instance, "six.function_reference").Invoke(store, 2, 3);
        }

        private Function GetFunction(Store store, Instance instance, string name)
        {
            var function = instance.GetFunction(store, name);

            if (function == null)
            {
                throw new InvalidOperationException("error: function export ``{name}´´ is missing");
            }
            return function;
        }
    }
}
