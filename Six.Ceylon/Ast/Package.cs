namespace Six.Ceylon.Ast
{
    public class Package
    {
        public Package(string name, FileJob? packageFile = null)
        {
            Name = name;
            PackageFile = packageFile;
        }

        public string Name { get; }
        public FileJob? PackageFile { get; }
        public List<FileJob> Files { get; } = new List<FileJob>();
    }
}
