using Six.Runtime;
using System.Reflection;

namespace Six.Runtime
{
    public class Loader
    {
        public static IEnumerable<FileJob> LoadAll(Type type)
        {
            foreach (var resourceName in type.Assembly.GetManifestResourceNames())
            {
                var ns = type.Namespace + ".";
                var rest = resourceName[ns.Length..];
                var name = Path.GetExtension(Path.GetFileNameWithoutExtension(rest))[1..] + Path.GetExtension(rest);
                var dir = rest[..^name.Length].Replace(".", "/") + name;
                yield return LoadEmbedded(type.Assembly, resourceName, dir, name);
            }
        }

        private static FileJob LoadEmbedded(Assembly assembly, string resourceName, string path, string name)
        {
            return new FileJob(path, name, () => LoadEmbedded(assembly, resourceName));
        }

        private static string LoadEmbedded(Assembly assembly, string resourceName)
        {
            var content = string.Empty;
            using (var stream = assembly.GetManifestResourceStream(resourceName)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }
    }
}
