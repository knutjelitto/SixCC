namespace Six.Ceylon.Ast
{
    public class Package : AstNode
    {
        public Package(Module module, string name, SourceFile? packageFile = null)
        {
            Module = module;
            Name = name;
            PackageFile = packageFile;
        }

        public Module Module { get; }
        public string Name { get; }
        public SourceFile? PackageFile { get; }
        public List<SourceFile> Files { get; } = new List<SourceFile>();
    }
}
