using System.Reflection;

namespace Six.Runtime
{
    public class SourceFile
    {
        public SourceFile(string fullname, string name, string content)
        {
            Fullname = fullname;
            Name = name;
            Content = content;
        }

        public string Fullname { get; }
        public string Name { get; }
        public string Content { get; }

        public static IEnumerable<SourceFile> LoadAll()
        {
            var assembly = typeof(SourceFile).Assembly;

            foreach (var resourceName in assembly.GetManifestResourceNames())
            {
                var rest = resourceName.Substring("Six.Ceylon.".Length);
                var name = Path.GetExtension(Path.GetFileNameWithoutExtension(rest)).Substring(1) + Path.GetExtension(rest);
                var dir = rest.Substring(0, rest.Length - name.Length).Replace(".", "/") + name;
                yield return LoadEmbedded(assembly, resourceName, dir, name);
            }
        }

        private static SourceFile LoadEmbedded(Assembly assembly, string resourceName, string path, string name)
        {
            var content = string.Empty;
            using (var stream = assembly.GetManifestResourceStream(resourceName)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return new SourceFile(path, name, content);
        }


    }
}
