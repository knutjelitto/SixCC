using System;

using Wasmtime;

using S = Six.Six.Sema;

#pragma warning disable CA1822 // Mark members as static

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

            if (smodule.HasErrors)
            {
                return;
            }

            Run(wat);
        }
        
        public void Run(string wat)
        {
            var config = new Config()
                .WithCompilerStrategy(CompilerStrategy.Cranelift);

            using var engine = new Engine(config);

            using var module = Module.FromText(engine, S.Module.CoreNamespace, wat);
            using var linker = new Linker(engine);
            using var store = new Store(engine);

            Memory? memory = null;

            linker.DefineFunction<int>("six.core.RT", "Print", (ptr) =>
            {
            });

            linker.DefineWasi();

            var instance = linker.Instantiate(store, module);

            memory = instance.GetMemory(store, "six.core.Data&Heap")!;

            var result = CallInt32Function(store, instance, "six.core.result_with_consts", 42);
            Assert(result == 48);

            result = CallInt32Function(store, instance, "six.core.function_reference", 2, 3);
            Assert(result  == 5);

            result = CallInt32Function(store, instance, "six.core.min", 2, 3);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.min", 3, 2);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.add_mul", 1, 2, 3);
            Assert(result == 7);

            var heap_start = (int)instance.GetGlobal(store, "six.core.__heap_start")!.GetValue(store)!;

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 7)!;
            Assert(result == heap_start);

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 17);
            Assert(result == heap_start + 16);

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 17);
            Assert(result == heap_start + 16 + 32);

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 17);
            Assert(result == heap_start + 16 + 32 + 32);

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 7);
            Assert(result == heap_start + 16 + 32 + 32 + 32);

            result = CallInt32Function(store, instance, S.Module.CoreAlloc, 7);
            Assert(result == heap_start + 16 + 32 + 32 + 32 + 16);

            var heap_current = (int)instance.GetGlobal(store, "six.core.__heap_current")!.GetValue(store)!;
            Assert(heap_current == heap_start + 16 + 32 + 32 + 32 + 16 + 7);

            var complex1 = CallInt32Function(store, instance, "six.core.get_complex");
            Assert(complex1 == heap_start + 144);
            var complex2 = CallInt32Function(store, instance, "six.core.get_complex");
            Assert(complex2 == heap_start + 160);

            result = CallInt32Function(store, instance, "six.core.Complex.Re", complex1);
            Assert(result == 1);
            result = CallInt32Function(store, instance, "six.core.Complex.Im", complex1);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.Complex.Re", complex2);
            Assert(result == 1);
            result = CallInt32Function(store, instance, "six.core.Complex.Im", complex2);
            Assert(result == 2);

            var sum = CallInt32Function(store, instance, "six.core.add_complex", complex1, complex2);
            Assert(sum == heap_start + 176);

            result = CallInt32Function(store, instance, "six.core.Complex.Re", sum);
            Assert(result == 2);
            result = CallInt32Function(store, instance, "six.core.Complex.Im", sum);
            Assert(result == 4);

            result = CallInt32Function(store, instance, "six.core.complex_string");
            Assert(true);

            result = CallInt32Function(store, instance, "six.core.tests.ShapeTest");
            Assert(result == 4);

            var address = CallInt32Function(store, instance, "six.core.tests.ShapeTest2");
        
            Assert(true);

            var mem = instance.GetMemory(store, "six.core.Data&Heap")!;

            var vtable = $"{mem.ReadInt32(store, address + 0):X4}";
            var dispatch = $"{mem.ReadInt32(store, address + 4):X4}";
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
                throw new InvalidOperationException($"error: function export ``{name}´´ is missing");
            }
            return function;
        }
    }
}
