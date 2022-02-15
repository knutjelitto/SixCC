using Six.Runtime;
using System.IO;

namespace Six.Six.Compiler
{
    public class Module
    {
        public Module(SourceFile moduleFile)
        {
            ModuleFile = moduleFile;
        }

        public SourceFile ModuleFile { get; }
        public List<Folder> Folders { get; } = new List<Folder>();

        public string Name => Path.GetDirectoryName(ModuleFile.ShortPath)!.Replace("\\", "/");
    }
}
