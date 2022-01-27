namespace Six.Ceylon
{
    public static class Runner
    {
        public const string CeylonRoot = "ceylon";
        public const string SixRoot = "six";
        public const string TestsRoot = "tests";

        public static void Run()
        {
            Generator.Run();
            //AllModules(fromRoot: TestsRoot, new CompilerConfiguration { WithRuleIndex = false });
            //AllModules(fromRoot: CeylonRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = false, });
            AllModules(fromRoot: SixRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = true, });
        }

        private static void AllModules(string fromRoot, CompilerConfiguration configuration)
        {
            var modules = CeylonLoader.GetModules(fromRoot).OrderBy(m => m.Name).ToList();

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
            catch (Exception exception)
            {
                Console.WriteLine();
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.ToString());
            }
        }
    }
}
