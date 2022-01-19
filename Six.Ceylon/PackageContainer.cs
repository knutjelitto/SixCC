namespace Six.Ceylon
{
    public class PackageContainer
    {
        public PackageContainer(FileJob packageFile)
        {
            PackageFile = packageFile;
        }

        public FileJob PackageFile { get; }
        public List<FileJob> Files { get; } = new List<FileJob>();

        public string Name => Path.GetDirectoryName(PackageFile.Fullname)!.Replace("\\", ".");
    }
}
