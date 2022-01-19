using Six.Runtime;
using System.Reflection;

namespace Six.Ceylon
{
    public static class Loader
    {
        public static IEnumerable<FileJob> LoadAll()
        {
            var assembly = typeof(Loader).Assembly;

            foreach (var resourceName in assembly.GetManifestResourceNames())
            {
                var rest = resourceName["Six.Ceylon.".Length..];
                var name = Path.GetExtension(Path.GetFileNameWithoutExtension(rest))[1..] + Path.GetExtension(rest);
                var dir = rest[..^name.Length].Replace(".", "/") + name;
                yield return LoadEmbedded(assembly, resourceName, dir, name);
            }
        }

        private static FileJob LoadEmbedded(Assembly assembly, string resourceName, string path, string name)
        {
            return new FileJob(path, name, () => LoadEmbedded(assembly, resourceName));
        }

        private static string LoadEmbedded(Assembly assembly, string resourceName)
        {
            var content = string.Empty;
            using (var stream = assembly.GetManifestResourceStream(resourceName)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }

        public static IEnumerable<Module> GetModules()
        {
            var files = LoadAll().ToList();

            foreach (var file in files.Where(f => IsModule(f)))
            {
                yield return GetModule(file, files);
            }
        }

        public static Module GetModule(FileJob moduleFile, List<FileJob> allFiles)
        {
            var module = new Module(moduleFile);

            var packages = GetPackages(module, allFiles);
            module.Packages.AddRange(packages.OrderBy(p => p.Name));

            return module;
        }

        public static IEnumerable<Package> GetPackages(Module module, List<FileJob> allFiles)
        {
            var modDir = Path.GetDirectoryName(module.ModuleFile.Fullname)!;

            foreach (var file in allFiles)
            {
                if (Path.GetDirectoryName(file.Fullname)!.StartsWith(modDir))
                {
                    if (IsPackage(file))
                    {
                        yield return GetPackage(file, allFiles);
                    }
                }
            }
        }

        public static Package GetPackage(FileJob packageFile, List<FileJob> allFiles)
        {
            var package = new Package(packageFile);

            var files = GetFiles(package, allFiles).ToList();
            package.Files.AddRange(files);

            return package;
        }

        public static IEnumerable<FileJob> GetFiles(Package package, List<FileJob> allFiles)
        {
            var packageDir = Path.GetDirectoryName(package.PackageFile.Fullname)!;

            foreach (var file in allFiles)
            {
                if (Path.GetDirectoryName(file.Fullname) == packageDir && !IsPackage(file))
                {
                    yield return file;
                }
            }
        }

        public static bool IsModule(FileJob file)
        {
            return string.Compare(file.Name, "module.ceylon", true) == 0;
        }

        public static bool IsPackage(FileJob file)
        {
            return string.Compare(file.Name, "package.ceylon", true) == 0;
        }


    }
}
