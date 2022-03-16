using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public void EmitModule()
        {
            wl($"(module");
            foreach (var global in Module.GetGlobals())
            {
                indent(() =>
                {
                    wl($"(global{ IdFor(global)}{ ExportIff(global)} {TypeFor(global)}");
                    indent(() => Emit(global.Value));
                    wl($")");
                });
            }

            foreach (var function in Module.GetFunctions())
            {
                indent(() =>
                {
                    Emit(function);
                });
            }

            indent(() =>
            {
                foreach (var classy in Module.GetClassies())
                {
                    if (!classy.IsNative())
                    {
                        dumper.Dump(classy);
                    }
                }
                wl();

                VerticalSpaced(functions);
                if (globalFunctionsTable.Count > 0)
                {
                    wl();
                    wl($"(table {globalFunctionsTableName} {globalFunctionsTable.Count} anyfunc)");
                    wl($"(elem (table {globalFunctionsTableName}) ({Insn.U32.Const(0)})");
                    var more = false;
                    indent(() =>
                    {
                        foreach (var (name, element) in globalFunctionsTable.OrderBy(kv => kv.Value.index))
                        {
                            if (more)
                            {
                                wl($",");
                            }
                            more = true;
                            w($"${name}");
                        }
                        wl(")");
                    });
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
