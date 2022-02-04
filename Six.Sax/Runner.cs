using Six.Sax.Compiler;

namespace Six.Sax
{
    public static class Runner
    {
        public const string Prefix = "src";
        public const string SixRoot = "sax";
        public const string CeylonRoot = "ceylon";
        public const string TestsRoot = "tests";

        public static void Run()
        {
            Generator.Run();
            //AllModules(fromRoot: TestsRoot, new CompilerConfiguration { WithRuleIndex = false });
            //AllModules(fromRoot: CeylonRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = false, });
            AllModules(fromRoot: SixRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = true, BuildTypes = true });
        }

        private static void AllModules(string fromRoot, CompilerConfiguration configuration)
        {
            var modules = new SaxLoader(Prefix).GetModules(fromRoot).OrderBy(m => m.Name).ToList();

            var compiler = new CeylonCompiler(configuration);

            try
            {
                foreach (var module in modules)
                {
                    if (!compiler.BuildModule(module))
                    {
                        break;
                    }
                }

                compiler.Report();
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
