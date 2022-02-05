using Six.Runtime;
using System.IO;
using System.Linq;

namespace Six.Sax.Compiler
{
    public class SaxLoader : Loader
    {
        private const string moduleFile = "module.sax";
        private const string fileGlob = "*.sax";

        public string Prefix { get; }

        public SaxLoader(string prefix)
        {
            Prefix = prefix;
        }

        public IEnumerable<Module> GetModules(string fromRoot)
        {
            var moduleFiles = LoadFiles(fromRoot, s => Path.GetFileName(s) == moduleFile).ToList();

            foreach (var moduleFile in moduleFiles)
            {
                yield return GetModule(moduleFile);
            }
        }

        private Module GetModule(SourceFile moduleFile)
        {
            var module = new Module(moduleFile);

            FindFolders(module);

            return module;
        }

        private IEnumerable<SourceFile> LoadFiles(string relative, System.Func<string, bool>? filter = null)
        {
            filter ??= n => true;

            var current = System.Environment.CurrentDirectory;
            var absolute = Path.Combine(current, Prefix, relative);
            foreach (var fullPath in Directory.EnumerateFiles(absolute, "*", SearchOption.AllDirectories).Where(n => filter(n)))
            {
                var shortPath = fullPath[(current.Length + Prefix.Length + 2)..].Replace("\\", "/");

                yield return MakeFile(fullPath.Replace("\\", "/"), shortPath);
            }
        }

        private SourceFile MakeFile(string fullPath, string shortPath)
        {
            return new SourceFile(fullPath, shortPath, () => File.ReadAllText(fullPath));
        }

        private void FindFolders(Module module)
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

                var folderName = dir[prefixLength..].Replace("\\", "/");//.Replace("/", ".");

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

        private bool IsModule(string file)
        {
            return Path.GetFileName(file) == moduleFile;
        }
    }
}
