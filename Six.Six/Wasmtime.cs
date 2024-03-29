﻿using System;

using Six.Six.Wasms;

using Wasmtime;

using SModule = Six.Six.Sema.Module;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six
{
    public class Wasmtime
    {
        public void Run(SModule smodule)
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

            using var module = Module.FromText(engine, SModule.CoreNamespace, wat);
            using var linker = new Linker(engine);
            using var store = new Store(engine);

            Memory? memory = null;

            linker.DefineFunction<int>("six.core.RT", "Print", (ptr) =>
            {
                Assert(memory != null);

                if (memory != null)
                {
                    var str = WaRef.FromObjectAddress((uint)ptr);
                    var length = memory.ReadInt32(store,(int)((uint)ptr - WaRef.HeaderSize + WaRef.Head.Size));
                    Assert(length == 5);
                    var message = memory.ReadString(store, ptr + (int)WaRef.OffsetOf(0), length);
                    Assert(message[0] == 'H');

                    Console.Write(message);
                }
            });

            linker.DefineWasi();

            var instance = linker.Instantiate(store, module);

            memory = instance.GetMemory(store, SModule.LinearMemory)!;

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

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 7)!;
            Assert(result == heap_start);

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 17);
            Assert(result == heap_start + 16);

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 17);
            Assert(result == heap_start + 16 + 32);

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 17);
            Assert(result == heap_start + 16 + 32 + 32);

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 7);
            Assert(result == heap_start + 16 + 32 + 32 + 32);

            result = CallInt32Function(store, instance, SModule.CoreAlloc, 7);
            Assert(result == heap_start + 16 + 32 + 32 + 32 + 16);

            var heap_current = (int)instance.GetGlobal(store, "six.core.__heap_current")!.GetValue(store)!;
            Assert(heap_current == heap_start + 16 + 32 + 32 + 32 + 16 + 7);

            var complex1 = CallInt32Function(store, instance, "six.core.get_complex");
            Assert(complex1 == heap_start + 160);
            var complex2 = CallInt32Function(store, instance, "six.core.get_complex");
            Assert(complex2 == heap_start + 160 + 32);

            result = CallInt32Function(store, instance, "six.core.Complex.Real", complex1);
            Assert(result == 1);
            result = CallInt32Function(store, instance, "six.core.Complex.Imag", complex1);
            Assert(result == 2);

            result = CallInt32Function(store, instance, "six.core.Complex.Real", complex2);
            Assert(result == 1);
            result = CallInt32Function(store, instance, "six.core.Complex.Imag", complex2);
            Assert(result == 2);

            var sum = CallInt32Function(store, instance, "six.core.add_complex", complex1, complex2);
            Assert(sum == heap_start + 160 + 32 + 32);

            result = CallInt32Function(store, instance, "six.core.Complex.Real", sum);
            Assert(result == 2);
            result = CallInt32Function(store, instance, "six.core.Complex.Imag", sum);
            Assert(result == 4);

            result = CallInt32Function(store, instance, "six.core.complex_string");
            Assert(true);

            CallVoidFunction(store, instance, "six.core.PrintHello");

            result = CallInt32Function(store, instance, "six.core.tests.ShapeTest");
            Assert(result == 4);

            var address = CallInt32Function(store, instance, "six.core.tests.ShapeTest2");        
            Assert(true);

            result = CallInt32Function(store, instance, "six.core.tests.WhileLoop");
            Assert(result == 10 + 9 + 8 + 7 + 6 + 5 + 4 + 3 + 2 + 1);

            var vtable = $"{memory.ReadInt32(store, address + 0):X4}";
            var dispatch = $"{memory.ReadInt32(store, address + 4):X4}";
        }

        private int CallInt32Function(Store store, Instance instance, string name, params object[] parameters)
        {
            return (int)GetFunction(store, instance, name).Invoke(store, parameters)!;
        }

        private void CallVoidFunction(Store store, Instance instance, string name, params object[] parameters)
        {
            _ = GetFunction(store, instance, name).Invoke(store, parameters)!;
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
