namespace Six.Core
{
    public static class WriterExtensions
    {
        private const string top = "bot";

        public static string File(string filename)
        {
            return Path.Combine(Temp.TempPath(top), filename);
        }

        public static Writer Writer(this string filename, int? indent = null)
        {
            return new Writer(File(filename), indent);
        }
    }
}
