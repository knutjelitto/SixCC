using Six.Six.Builtins;
using Six.Six.Sema;
using System;

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
                            Emit(Insn.U32.Const(WasmDef.Align(16, ClassData.Next)));
                        }
                        else if (global.FullName == Module.Heap_Current)
                        {
                            Emit(Insn.U32.Const(WasmDef.Align(16, ClassData.Next)));
                        }
                        else
                        {
                            Emit(global.Value);
                        }
                    });
                    wl($")");
                }
                wl();

                EmitAlloc();
                wl();

                foreach (var function in Module.GetFunctions())
                {
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
                DispatchTable.EmitTable();
                wl();
                Types.Emit();
            });
            wl($")");
        }

        public Func<Ptr> AddString(string text)
        {
            return StringData.Add(text);
        }

        public Func<Ptr> AddClass(ClassLayout layout)
        {
            return ClassData.Add(layout);
        }

        private void EmitAlloc()
        {
            wl($"(func ${Module.CoreClassAlloc}");
            indent(() =>
            {
                wl($"(export \"{Module.CoreClassAlloc}\")");
                wl($"(param {WasmDef.Pointer})");
                wl($"(result {WasmDef.Pointer})");
                wl($"(local {WasmDef.Pointer})");
                wl("(;-----;)");
                Emit(Insn.Local.Get(0));
                Emit(Insn.U32.Load(4));
                Emit(Insn.Call(Module.CoreAlloc));
                Emit(Insn.Local.Tee(1));
                Emit(Insn.Local.Get(0));
                Emit(Insn.U32.Const(16));
                Emit(Insn.U32.Add);
                Emit(Insn.U32.Store(0));
                Emit(Insn.Local.Get(1));
                Emit(Insn.Return);
                wl("(;-----;)");
            });
            wl($")");
        }
    }
}
