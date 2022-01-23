namespace Six.Ceylon
{
    public static class Runner
    {
        public static void Run()
        {
            Generator.Run();
            AllModules(fromRoot: CeylonLoader.TestsRoot, withIndex: true);
        }

        private static void AllModules(string fromRoot, bool withIndex = false)
        {
            var modules = CeylonLoader.GetModules(fromRoot).OrderBy(m => m.Name).ToList();

            var compiler = new CeylonCompiler(withIndex: withIndex);

            try
            {
                foreach (var module in modules)
                {
                    if (!compiler.BuildModule(module))
                    {
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine();
                Console.WriteLine(exception.Message);
            }

            compiler.Report();
        }
    }
}
