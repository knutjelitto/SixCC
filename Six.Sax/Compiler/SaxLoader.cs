using Six.Runtime;
using System.IO;

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

        public Module? GetModule(string fromRoot)
        {
            var file = LoadModule(fromRoot);

            if (file != null)
            {
                return GetModule(file);
            }
            return null;
        }

        private Module GetModule(SourceFile moduleFile)
        {
            var module = new Module(moduleFile);

            FindFolders(module);

            return module;
        }

        private SourceFile? LoadModule(string relative)
        {
            var current = System.Environment.CurrentDirectory;
            var absolute = Path.Combine(current, Prefix, relative);
            foreach (var fullPath in Directory.EnumerateFiles(absolute, moduleFile, SearchOption.AllDirectories))
            {
                var shortPath = fullPath[(current.Length + Prefix.Length + 2)..].Replace("\\", "/");

                return MakeFile(fullPath.Replace("\\", "/"), shortPath);
            }
            return null;
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
