using Six.Six.Builtins;
using Six.Six.Sema;
using System;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public void EmitModule()
        {
            Preparer.Prepare();

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

                foreach (var classy in Module.GetClassies())
                {
                    if (!classy.IsPrefinal)
                    {
                        dumper.Dump(classy);
                    }
                }
                wl();

                foreach (var function in Module.GetFunctions())
                {
                    Emit(function);
                    wl();
                }

                foreach (var classy in Module.GetClassies())
                {
                    if (classy.IsPrefinal)
                    {
                        Emit(classy);
                    }
                }
                wl();

                GlobalFunctions.Emit();
                wl();
                Types.Emit();
            });
            wl($")");
        }

        public Func<Ptr> AddString(string text)
        {
            return StringData.Add(text);
        }

        public Func<Ptr> AddClass(string fullName, uint size)
        {
            return ClassData.Add(fullName, size);
        }
    }
}
