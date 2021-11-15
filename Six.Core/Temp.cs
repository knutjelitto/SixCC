namespace Six.Core
{
    public static class Temp
    {
        public static string TempPath(string top)
        {
            var outPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../../../..", "SixTmp", top));
            if (!Directory.Exists(outPath))
            {
                _ = Directory.CreateDirectory(outPath);
            }
            return outPath;
        }
    }
}
