namespace Six.Ceylon
{
    public static class Runner
    {
        public static void Run()
        {
            Generator.Run();
            AllModules();
        }

        private static void AllModules()
        {
            var modules = CeylonLoader.GetModules().OrderBy(m => m.Name).ToList();

            var compiler = new CeylonCompiler(withIndex: false);

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
