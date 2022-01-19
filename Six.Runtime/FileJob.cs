using Six.Core;
using Six.Runtime.Types;

namespace Six.Runtime
{
    public class FileJob
    {
        private string? content;
        private Source? source;

        public FileJob(string fullname, string name, Func<string> contentLoader)
        {
            Fullname = fullname;
            Name = name;
            ContentLoader = contentLoader;
        }

        public string Fullname { get; }
        public string Name { get; }
        public string BaseName => Path.GetFileNameWithoutExtension(Name);
        public Func<string> ContentLoader { get; }
        public string Content => content ??= ContentLoader();
        public Source Source => source ??= Source.FromString(Name, Content);
        public RNode? Tree { get; set; }
    }
}
