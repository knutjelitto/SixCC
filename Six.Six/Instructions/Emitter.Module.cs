using Six.Six.Sema;
using System;
using static Six.Six.Ast.Using;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public void EmitModule()
        {
            wl($"(module");
            foreach (var function in Module.GetFunctions())
            {
                indent(() =>
                {
                    Emit(function);
                });
            }

            indent(() =>
            {
                Dump("method", Module.GetMethods().ToList());
                Dump("attribute", Module.GetAttributes().ToList());

                void Dump<T>(string what, List<T> decls)
                    where T : Decl
                {
                    foreach (var attribute in decls)
                    {
                        wl($"(; {what} - {attribute.FullName().Replace(".block.", ".")} ;)");
                    }
                    if (decls.Count > 0)
                    {
                        wl();
                    }
                }

                VerticalSpaced(functions.Select(function => function));
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
