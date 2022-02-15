using Six.Six.Compiler;

using S = Six.Six.Sema;

namespace Six.Six
{
    public static class Runner
    {
        public const string Prefix = "src";
        public const string SixRoot = "six";
        public const string FirstRoot = "first";

        public static void Run()
        {
            Generator.Run();
            LoadModule(
                fromRoot: SixRoot, 
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

        private static void LoadModule(string fromRoot, CompilerConfiguration configuration)
        {
            var module = new SixLoader(Prefix).GetModule(fromRoot);

            if (module != null)
            {
                var global = new S.Module();
                var compiler = new SixCompiler(global, configuration);

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
