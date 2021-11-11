namespace SixTools.Formats
{
    public static class Formatter
    {
        public static readonly IFormat[] Formatters = new[]
        {
            (IFormat)
            new RailSvg.RailHtmlFormat(),
            new AstDumpFormat(),
            new RailDumpFormat(),
            new SixgFormat(),
            new HtmlFormat(),
        };

        public static string TempPath()
        {
            var outPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../../../..", "SixTmp", "tools"));
            if (!Directory.Exists(outPath))
            {
                _ = Directory.CreateDirectory(outPath);
            }
            return outPath;
        }
    }
}
