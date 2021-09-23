using Six.Tools;
using System;

namespace Six.Ceylon
{
    public class CompileStatistics
    {
        public CompileStatistics(FileRef file)
        {
            File = file;
        }

        public FileRef File { get; }
        public int Lines { get; set; } = -1;
        public TimeSpan GrossTime { get; set; } = TimeSpan.Zero;
        public TimeSpan ParseTime { get; set; } = TimeSpan.Zero;
        public TimeSpan AstTime { get; set; } = TimeSpan.Zero;
        public int ParseLps => (int)Math.Round(Lines / ParseTime.TotalSeconds);
    }
}
