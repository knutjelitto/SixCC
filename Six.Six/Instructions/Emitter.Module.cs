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
                wl($"(memory ${Module.DataAndHeap} (export \"{Module.DataAndHeap}\") 16 16)");
                wl();
                StringData.Emit(32);
                wl();
                ClassData.Emit(StringData.Next);
                wl();
                foreach (var global in Module.GetGlobals())
                {
                    wl($"(global{IdFor(global)}{ExportIff(global)}{TypeFor(global)}");
                    indent(() => Emit(global.Value));
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
