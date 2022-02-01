namespace Six.Ceylon.Ast
{
    public class Folder : AstNode
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
