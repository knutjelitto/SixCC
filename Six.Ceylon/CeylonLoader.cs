using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class CeylonLoader : Loader
    {
        private const string moduleFile = "module.ceylon";
        private const string fileGlob = "*.ceylon";

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

            FindFolders(module);

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
            if (shortPath == moduleFile)
            {
                Assert(true);
            }
            return new SourceFile(fullPath, shortPath, () => File.ReadAllText(fullPath));
        }


        private static void FindFolders(Module module)
        {
            var root = Path.GetDirectoryName(module.ModuleFile.LongPath)!;
            var prefixLength = module.ModuleFile.LongPath.Length - module.ModuleFile.ShortPath.Length;

            foreach (var dir in Enumerable.Repeat(root, 1).Concat(Directory.EnumerateDirectories(root, "*", SearchOption.AllDirectories)))
            {
                var hasFiles = Directory.EnumerateFiles(dir, fileGlob, SearchOption.TopDirectoryOnly)
                    .Where(file => !IsModule(file))
                    .Any();

                if (!hasFiles)
                    continue;

                var folderName = dir[prefixLength..].Replace("\\", "/").Replace("/", ".");

                var folder = new Folder(module, folderName);

                foreach (var file in Directory.EnumerateFiles(dir, fileGlob, SearchOption.TopDirectoryOnly))
                {
                    if (IsModule(file))
                    {
                        continue;
                    }
                    var fullPath = file.Replace("\\", "/");
                    var shortPath = file[prefixLength..].Replace("\\", "/");

                    folder.Files.Add(MakeFile(fullPath, shortPath));
                }

                module.Folders.Add(folder);
            }
        }

        private static bool IsModule(string file)
        {
            return Path.GetFileName(file) == moduleFile;
        }
    }
}
