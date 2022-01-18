using Six.Runtime;

namespace Six.Ceylon
{
    public class Package
    {
        public Package(SourceFile packageFile)
        {
            PackageFile = packageFile;
        }

        public SourceFile PackageFile { get; }
        public List<SourceFile> Files { get; } = new List<SourceFile>();

        public string Name => Path.GetDirectoryName(PackageFile.Fullname)!.Replace("\\", ".");
    }
}
