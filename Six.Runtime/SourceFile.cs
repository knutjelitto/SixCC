using System.Reflection;

namespace Six.Runtime
{
    public class SourceFile
    {
        private string? content;

        public SourceFile(string fullname, string name, Func<string> contentLoader)
        {
            Fullname = fullname;
            Name = name;
            ContentLoader = contentLoader;
        }

        public string Fullname { get; }
        public string Name { get; }
        public string BaseName => Path.GetFileNameWithoutExtension(Name);
        public Func<string> ContentLoader { get; }
        public string Content { get { return content ??= ContentLoader(); } }
    }
}
