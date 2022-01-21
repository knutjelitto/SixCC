namespace Six.Core
{
    public static class Files
    {
        public static bool NewerThan(string file1, string file2)
        {
            return !File.Exists(file2) || File.GetLastWriteTimeUtc(file1) > File.GetLastWriteTimeUtc(file2);
        }
    }
}
