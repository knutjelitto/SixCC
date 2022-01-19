namespace Six.Ceylon
{
    public class CeylonLoader : Loader
    {
        public static IEnumerable<ModuleContainer> GetModules()
        {
            var files = LoadAll(typeof(CeylonLoader)).ToList();

            foreach (var file in files.Where(f => IsModule(f)))
            {
                yield return GetModule(file, files);
            }
        }

        public static ModuleContainer GetModule(FileJob moduleFile, List<FileJob> allFiles)
        {
            var module = new ModuleContainer(moduleFile);

            var packages = GetPackages(module, allFiles);
            module.Packages.AddRange(packages.OrderBy(p => p.Name));

            return module;
        }

        public static IEnumerable<PackageContainer> GetPackages(ModuleContainer module, List<FileJob> allFiles)
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

        public static PackageContainer GetPackage(FileJob packageFile, List<FileJob> allFiles)
        {
            var package = new PackageContainer(packageFile);

            var files = GetFiles(package, allFiles).ToList();
            package.Files.AddRange(files);

            return package;
        }

        public static bool IsModule(FileJob file)
        {
            return string.Compare(file.Name, "module.ceylon", true) == 0;
        }

        public static bool IsPackage(FileJob file)
        {
            return string.Compare(file.Name, "package.ceylon", true) == 0;
        }

        public static IEnumerable<FileJob> GetFiles(PackageContainer package, List<FileJob> allFiles)
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
    }
}
