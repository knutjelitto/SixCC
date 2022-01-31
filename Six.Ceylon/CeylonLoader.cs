using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class CeylonLoader : Loader
    {
        private const string packageFile = "package.ceylon";
        private const string moduleFile = "module.ceylon";

        public static IEnumerable<Module> GetModules(string fromRoot)
        {
            var moduleFiles = LoadFiles(fromRoot, s => Path.GetFileName(s) == moduleFile).ToList();

            foreach (var moduleFile in moduleFiles)
            {
                yield return GetModule(moduleFile);
            }
        }

        private static Module GetModule(SourceFile moduleFile)
        {
            var module = new Module(moduleFile);

            FindPackages(module);

            return module;
        }

        private static IEnumerable<SourceFile> LoadFiles(string fromRoot, System.Func<string, bool>? filter = null)
        {
            filter ??= n => true;

            var current = System.Environment.CurrentDirectory;
            var filesRoot = Path.Combine(current, fromRoot);
            foreach (var fullPath in Directory.EnumerateFiles(filesRoot, "*", SearchOption.AllDirectories).Where(n => filter(n)))
            {
                var shortPath = fullPath[(current.Length + 1)..].Replace("\\", "/");

                yield return MakeFile(fullPath.Replace("\\", "/"), shortPath);
            }
        }

        private static SourceFile MakeFile(string fullPath, string shortPath)
        {
            if (shortPath == packageFile || shortPath == moduleFile)
            {
                Assert(true);
            }
            return new SourceFile(fullPath, shortPath, () => File.ReadAllText(fullPath));
        }


        private static void FindPackages(Module module)
        {
            var root = Path.GetDirectoryName(module.ModuleFile.LongPath)!;
            var prefixLength = module.ModuleFile.LongPath.Length - module.ModuleFile.ShortPath.Length;

            foreach (var dir in Enumerable.Repeat(root, 1).Concat(Directory.EnumerateDirectories(root, "*", SearchOption.AllDirectories)))
            {
                var hasFiles = Directory.EnumerateFiles(dir, "*.ceylon", SearchOption.TopDirectoryOnly)
                    .Where(file => !IsPackageOrModule(file))
                    .Any();

                if (!hasFiles)
                    continue;

                var fullPath = Path.Combine(dir, packageFile).Replace("\\", "/");
                var shortPath = fullPath[prefixLength..].Replace("\\", "/");
                var packageName = dir[prefixLength..].Replace("\\", "/").Replace("/", ".");

                Package package;

                if (File.Exists(fullPath))
                {
                    package = new Package(module, packageName, MakeFile(fullPath, shortPath));
                }
                else
                {
                    package = new Package(module, packageName);
                }

                foreach (var file in Directory.EnumerateFiles(dir, "*.ceylon", SearchOption.TopDirectoryOnly))
                {
                    if (IsPackageOrModule(file))
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

        private static bool IsPackageOrModule(string file)
        {
            return Path.GetFileName(file) == packageFile || Path.GetFileName(file) == moduleFile;
        }
    }
}
