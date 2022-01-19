namespace Six.Ceylon
{
    public class ModuleContainer
    {
        public ModuleContainer(FileJob moduleFile)
        {
            ModuleFile = moduleFile;
        }

        public FileJob ModuleFile { get; }
        public List<PackageContainer> Packages { get; } = new List<PackageContainer>();

        public string Name => Path.GetDirectoryName(ModuleFile.Fullname)!.Replace("\\", ".");
    }
}
