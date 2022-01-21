using Six.Core;
using Six.Runtime.Types;

namespace Six.Runtime
{
    public class FileJob
    {
        private string? content;
        private Source? source;

        public FileJob(string longPath, string shortPath, Func<string> contentLoader)
        {
            LongPath = longPath;
            ShortPath = shortPath;
            ContentLoader = contentLoader;
        }

        public string LongPath { get; }
        public string ShortPath { get; }
        public string Name => Path.GetFileName(ShortPath);
        public Func<string> ContentLoader { get; }
        public string BaseName => Path.GetFileNameWithoutExtension(Name);
        public TimeSpan ParseTime { get; set; }
        public string Content => content ??= ContentLoader();
        public Source Source => source ??= Source.FromString(Name, Content);
        public RNode? Tree { get; set; }
    }
}
