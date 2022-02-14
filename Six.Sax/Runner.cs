using Six.Sax.Compiler;

using S = Six.Sax.Sema;

namespace Six.Sax
{
    public static class Runner
    {
        public const string Prefix = "src";
        public const string SaxRoot = "sax";

        public static void Run()
        {
            Generator.Run();
            AllModules(
                fromRoot: SaxRoot, 
                new CompilerConfiguration
                { 
                    WithRuleIndex = true, 
                    DumpSppf = false,
                    DumpTree = false, 
                    BuildAst = true, 
                    DumpAst = true,  
                    BuildTypes = true
                });
        }

        private static void AllModules(string fromRoot, CompilerConfiguration configuration)
        {
            var module = new SaxLoader(Prefix).GetModule(fromRoot);

            if (module != null)
            {
                var global = new S.Module();
                var compiler = new SaxCompiler(global, configuration);

                try
                {
                    compiler.BuildModule(module);
                }
                catch (System.Exception exception)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine(exception.Message);
                    System.Console.WriteLine(exception.ToString());
                }
            }
        }
    }
}
