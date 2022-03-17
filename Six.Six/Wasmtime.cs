using System;

using Wasmtime;

using S = Six.Six.Sema;

namespace Six.Six
{
    public class Wasmtime
    {
        public void Run(S.Module smodule)
        {
            if (smodule.HasErrors)
            {
                return;
            }

            var wat = smodule.Emit();

            var config = new Config()
                .WithCompilerStrategy(CompilerStrategy.Cranelift);

            using var engine = new Engine(config);
            using var module = Module.FromText(engine, "six.core", wat);
            using var linker = new Linker(engine);
            using var store = new Store(engine);

            linker.DefineWasi();

            var instance = linker.Instantiate(store, module);

            var result = CallInt32Function(store, instance, "six.core.result_with_consts", 42);
            Assert(result == 48);

            result = CallInt32Function(store, instance, "six.core.function_reference", 2, 3);
            Assert(result  == 5);

            result = CallInt32Function(store, instance, "six.core.min", 2, 3);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.min", 3, 2);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.allocate", 7)!;
            Assert(result == 0);

            result = CallInt32Function(store, instance, "six.core.allocate", 17);
            Assert(result == 16);

            result = CallInt32Function(store, instance, "six.core.allocate", 17);
            Assert(result == 16 + 32);

            result = CallInt32Function(store, instance, "six.core.allocate", 17);
            Assert(result == 16 + 32 + 32);

            result = CallInt32Function(store, instance, "six.core.allocate", 7);
            Assert(result == 16 + 32 + 32 + 32);

            result = CallInt32Function(store, instance, "six.core.allocate", 7);
            Assert(result == 16 + 32 + 32 + 32 + 16);

            result = (int)instance.GetGlobal(store, "six.core.__heap_next")!.GetValue(store)!;
            Assert(result == 16 + 32 + 32 + 32 + 16 + 7);
        }

        private int CallInt32Function(Store store, Instance instance, string name, params object[] parameters)
        {
            return (int)GetFunction(store, instance, name).Invoke(store, parameters)!;
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
