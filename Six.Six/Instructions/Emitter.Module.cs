using System;

using Six.Six.Sema;
using W = Six.Six.Wasms;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public void EmitModule()
        {
            if (Module.HasErrors)
            {
                return;
            }

            var wmodule = new W.Module();

            wl($"(module");
            indent(() =>
            {
                uint data_start = 32;

                wl($"(memory ${Module.DataAndHeap} (export \"{Module.DataAndHeap}\") 16 16)");
                wl();
                StringData.Emit(data_start);
                wl();
                ClassData.Emit(StringData.Next);
                wl();
                foreach (var global in Module.GetGlobals())
                {
                    wl($"(global{IdFor(global)}{ExportIff(global)}{TypeFor(global)}");
                    indent(() =>
                    {
                        if (global.FullName == Module.Data_Start)
                        {
                            Emit(Insn.U32.Const(data_start));
                        }
                        else if (global.FullName == Module.Heap_Start)
                        {
                            Emit(Insn.U32.Const(W.WasmType.Align(16, ClassData.Next)));
                        }
                        else if (global.FullName == Module.Heap_Current)
                        {
                            Emit(Insn.U32.Const(W.WasmType.Align(16, ClassData.Next)));
                        }
                        else
                        {
                            Emit(global.Value);
                        }
                    });
                    wl($")");
                }
                wl();

                EmitClassAlloc();
                wl();

                foreach (var function in Module.GetFunctions())
                {
                    wmodule.Add(wmodule.ToFunction(function));

                    Emit(function);
                    wl();
                }

                foreach (var classy in Module.GetClassies())
                {
                    Emit(classy);
                }
                wl();

                GlobalFunctions.EmitTable();
                wl();
                DispatchTable.Emit();
                wl();
                Types.Emit();
            });
            wl($")");

            wl();
            wmodule.Emit();
            w(wmodule.Writer.ToString());
        }

        public Func<Ptr> AddString(string text)
        {
            return StringData.Add(text);
        }

        public Func<Ptr> AddClass(ClassLayout layout)
        {
            return ClassData.Add(layout);
        }

        private void EmitClassAlloc()
        {
            wl($"(func ${Module.CoreClassAlloc}");
            indent(() =>
            {
                wl($"(export \"{Module.CoreClassAlloc}\")");
                wl($"(param {W.WasmType.Ptr})");
                wl($"(result {W.WasmType.Ptr})");
                wl($"(local {W.WasmType.Ptr})");
                wl("(;-----;)");
                Emit(Insn.Local.Get(0));            // [clazz]
                Emit(Insn.U32.Load(8));             // [clazz.size]
                Emit(Insn.Call(Module.CoreAlloc));  // [object]
                Emit(Insn.Local.Tee(1));            // [object]
                Emit(Insn.Local.Get(0));            // [object clazz]
                Emit(Insn.U32.Store(0));            // [] object.clazz = clazz

                Emit(Insn.Local.Get(1));            // [object]
                Emit(Insn.Local.Get(0));            // [object clazz]
                Emit(Insn.U32.Load(16));            // [object clazz.dispatch]
                Emit(Insn.U32.Store(4));            // [] object.dispatch = clazz.dispatch

                Emit(Insn.Local.Get(1));            // [object]
                Emit(Insn.Return);
                wl("(;-----;)");
            });
            wl($")");
        }
    }
}
