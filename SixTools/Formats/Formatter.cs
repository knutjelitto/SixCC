using Six.Core;

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
            return Temp.TempPath("tools");
        }
    }
}
