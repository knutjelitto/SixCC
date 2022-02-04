using Six.Runtime;

namespace Six.Sax.Compiler
{
    public class Folder
    {
        public Folder(Module module, string name)
        {
            Module = module;
            Name = name;
        }

        public Module Module { get; }
        public string Name { get; }
        public List<SourceFile> Files { get; } = new List<SourceFile>();
    }
}
