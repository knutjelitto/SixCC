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

        public static IEnumerable<Sample> LoadAll(Func<string, bool> filter)
        {
            var assembly = typeof(Sampler).Assembly;

            foreach (var name in assembly.GetManifestResourceNames())
            {
                if (filter(name))
                {
                    yield return LoadEmbedded(assembly, name);
                }
            }
        }

        private static Sample LoadEmbedded(Assembly assembly, string name)
        {
            var content = string.Empty;
            using (var stream = assembly.GetManifestResourceStream(name)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return new Sample(name, content);
        }
    }
}
