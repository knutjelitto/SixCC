namespace Six.Ceylon
{
    public class CeylonLoader : Loader
    {
        public const string CeylonRoot = "ceylon";
        public const string TestsRoot = "tests";

        private const string packageFile = "package.ceylon";
        private const string moduleFile = "module.ceylon";

        public static IEnumerable<ModuleContainer> GetModules(string fromRoot = CeylonRoot)
        {
            var moduleFiles = LoadFiles(fromRoot, s => Path.GetFileName(s) == moduleFile).ToList();

            foreach (var moduleFile in moduleFiles)
            {
                yield return GetModule(moduleFile);
            }
        }


        private static ModuleContainer GetModule(FileJob moduleFile)
        {
            var module = new ModuleContainer(moduleFile);

            FindPackages(module);

            return module;
        }

        private static IEnumerable<FileJob> LoadFiles(string fromRoot, Func<string, bool>? filter = null)
        {
            filter ??= n => true;

            var current = Environment.CurrentDirectory;
            var filesRoot = Path.Combine(current, fromRoot);
            foreach (var fullPath in Directory.EnumerateFiles(filesRoot, "*", SearchOption.AllDirectories).Where(n => filter(n)))
            {
                var shortPath = fullPath[(current.Length + 1)..].Replace("\\", "/");

                yield return MakeFile(fullPath.Replace("\\", "/"), shortPath);
            }
        }

        private static FileJob MakeFile(string fullPath, string shortPath)
        {
            return new FileJob(fullPath, shortPath, () => File.ReadAllText(fullPath));
        }


        private static void FindPackages(ModuleContainer module)
        {
            var root = Path.GetDirectoryName(module.ModuleFile.LongPath)!;
            var prefixLength = module.ModuleFile.LongPath.Length - module.ModuleFile.ShortPath.Length;

            foreach (var dir in Enumerable.Repeat(root, 1).Concat(Directory.EnumerateDirectories(root, "*", SearchOption.AllDirectories)))
            {
                var fullPath = Path.Combine(dir, packageFile).Replace("\\", "/");
                var shortPath = fullPath[prefixLength..].Replace("\\", "/");
                var packageName = dir[prefixLength..].Replace("\\", "/").Replace("/", ".");

                PackageContainer package;

                if (File.Exists(fullPath))
                {
                    package = new PackageContainer(packageName, MakeFile(fullPath, shortPath));
                }
                else
                {
                    package = new PackageContainer(packageName);
                }

                foreach (var file in Directory.EnumerateFiles(dir, "*.ceylon", SearchOption.TopDirectoryOnly))
                {
                    if (Path.GetFileName(file) == packageFile || Path.GetFileName(file) == moduleFile)
                    {
                        continue;
                    }
                    fullPath = file.Replace("\\", "/");
                    shortPath = file[prefixLength..].Replace("\\", "/");

                    package.Files.Add(MakeFile(fullPath, shortPath));
                }

                module.Packages.Add(package);
            }
        }
    }
}
