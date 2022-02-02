namespace Six.Ceylon
{
    public static class Runner
    {
        public const string CeylonRoot = "src/ceylon";
        public const string SixRoot = "src/six";
        public const string TestsRoot = "src/tests";

        public static void Run()
        {
            Generator.Run();
            //AllModules(fromRoot: TestsRoot, new CompilerConfiguration { WithRuleIndex = false });
            //AllModules(fromRoot: CeylonRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = false, });
            AllModules(fromRoot: SixRoot, new CompilerConfiguration { WithRuleIndex = true, DumpTree = true, BuildAst = true, BuildTypes = true });
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
            catch (System.Exception exception)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(exception.Message);
                System.Console.WriteLine(exception.ToString());
            }
        }
    }
}
