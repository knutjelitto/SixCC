using Six.Core;
using Six.Runtime.Sppf;
using Six.Runtime.Types;

namespace Six.Runtime
{
    public class SourceFile
    {
        private string? content;
        private Source? source;

        public SourceFile(string longPath, string shortPath, Func<string> contentLoader)
        {
            Assert(longPath.EndsWith(shortPath));

            if (shortPath == "package.ceylon")
            {
                Assert(true);
            }

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
        public Nonterminal? Sppf { get; set; }
        public RNode? Tree { get; set; }
    }
}
