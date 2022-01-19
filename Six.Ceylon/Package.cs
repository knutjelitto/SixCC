using Six.Runtime;

namespace Six.Ceylon
{
    public class Package
    {
        public Package(FileJob packageFile)
        {
            PackageFile = packageFile;
        }

        public FileJob PackageFile { get; }
        public List<FileJob> Files { get; } = new List<FileJob>();

        public string Name => Path.GetDirectoryName(PackageFile.Fullname)!.Replace("\\", ".");
    }
}
