namespace Six.Core
{
    public static class Files
    {
        public static bool NewerThan(string file1, string file2)
        {
            return File.GetLastWriteTimeUtc(file1) > File.GetLastWriteTimeUtc(file2);
        }
    }
}
