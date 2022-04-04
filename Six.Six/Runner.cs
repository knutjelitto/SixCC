using Six.Core;
using Six.Core.Errors;
using Six.Six.Compiler;
using System;
using S = Six.Six.Sema;

namespace Six.Six
{
    public static class Runner
    {
        public const string Prefix = "src";
        public const string SixRoot = "six";
        //public const string SixRoot = "test";

        public static bool Run()
        {
            Generator.Run();
            var module = LoadModule(
                fromRoot: SixRoot, 
                new CompilerConfiguration
                { 
                    WithRuleIndex = true, 
                    DumpSppf = false,
                    DumpTree = false, 
                    DumpAst = true,  
                });

            if (module != null)
            {
                try
                {
                    new Wasmtime().Run(module);

                    if (module.HasErrors)
                    {
                        module.WriteErrors();
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (DiagnosticException diagnostics)
                {
                    Console.WriteLine();
                    using (var writer = new Writer(Console.Out))
                    {
                        foreach (var diagnostic in diagnostics.Diagnostics)
                        {
                            diagnostic.Report(writer);
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine();
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.ToString());
                }
            }

            return false;
        }

        private static S.Module? LoadModule(string fromRoot, CompilerConfiguration configuration)
        {
            var module = new SixLoader(Prefix).GetModule(fromRoot);

            if (module != null)
            {
                var global = new S.Module();
                var compiler = new Compiler.Compiler(global, configuration);

                try
                {
                    compiler.BuildModule(module);
                    return global;
                }
                catch (System.Exception exception)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine(exception.Message);
                    System.Console.WriteLine(exception.ToString());
                }

            }

            return null;
        }
    }
}
