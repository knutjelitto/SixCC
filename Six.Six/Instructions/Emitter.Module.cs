using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public void EmitModule()
        {
            wl($"(module");
            indent(() =>
            {
                wl($"(memory ${Module.DataAndHeap} (export \"{Module.DataAndHeap}\") 16 16)");
                wl();
                foreach (var global in Module.GetGlobals())
                {
                    wl($"(global{ IdFor(global)}{ ExportIff(global)} {TypeFor(global)}");
                    indent(() => Emit(global.Value));
                    wl($")");
                }

                foreach (var function in Module.GetFunctions())
                {
                    Emit(function);
                }

                foreach (var classy in Module.GetClassies())
                {
                    if (!classy.IsNative)
                    {
                        dumper.Dump(classy);
                    }
                }
                wl();

                VerticalSpaced(functions);
                if (globalFunctionsTable.Count > 0)
                {
                    wl();
                    wl($"(table {globalFunctionsTableName} anyfunc (elem");
                    indent(() =>
                    {
                        foreach (var (name, element) in globalFunctionsTable.OrderBy(kv => kv.Value.index))
                        {
                            wl($"${name}");
                        }
                    });
                    wl("))");
                }
                if (functionTypes.Count > 0)
                {
                    wl();
                    foreach (var (name, index) in functionTypes.OrderBy(kv => kv.Value))
                    {
                        wl($"(type $funcType{index} {name})");
                    }
                }
            });
            wl($")");
        }
    }
}
