using Six.Six.Compiler;

using S = Six.Six.Sema;

namespace Six.Six
{
    public static class Runner
    {
        public const string Prefix = "src";
        public const string SixRoot = "six";
        //public const string SixRoot = "test";

        public static void Run()
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
                new Wasmtime().Run(module);
            }
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
