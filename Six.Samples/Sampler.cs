using System.Reflection;

namespace Six.Samples
{
    public static class Sampler
    {
        public static IEnumerable<Sample> LoadSix()
        {
            return LoadAll(name => name.EndsWith(".six"));
        }

        public static IEnumerable<Sample> LoadT()
        {
            return LoadAll(name => name.EndsWith(".t"));
        }

        public static IEnumerable<Sample> LoadE()
        {
            return LoadAll(name => name.EndsWith(".e"));
        }

        public static IEnumerable<Sample> LoadError()
        {
            return LoadAll(name => name.EndsWith(".error"));
        }

        public static IEnumerable<Sample> LoadJson()
        {
#if true
            return LoadAll(name => name.EndsWith(".json")).Where(s => !s.Name.StartsWith("_stack_"));
#else
            var root = "d:/Temp/JSONTestSuite/test_parsing";

            foreach (var filepath in Directory.EnumerateFiles(root, "*.json"))
            {
                if (Path.GetFileName(filepath).StartsWith("_stack_"))
                {
                    continue;
                }
                yield return LoadFile(filepath);
            }
#endif
        }

        public static IEnumerable<Sample> LoadAll(Func<string, bool> filter)
        {
            var assembly = typeof(Sampler).Assembly;

            foreach (var resourceName in assembly.GetManifestResourceNames())
            {
                if (filter(resourceName))
                {
                    var name = resourceName.Substring("Six.Samples.".Length);
                    name = name.Substring(name.IndexOf('.') + 1);
                    yield return LoadEmbedded(assembly, resourceName, name);
                }
            }
        }

        private static Sample LoadEmbedded(Assembly assembly, string resourceName, string name)
        {
            var content = string.Empty;
            using (var stream = assembly.GetManifestResourceStream(resourceName)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return new Sample(name, content);
        }

        private static Sample LoadFile(string filepath)
        {
            var content = File.ReadAllText(filepath);
            var name = Path.GetFileName(filepath);

            return new Sample(name, content);
        }
    }
}
