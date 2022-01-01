using System.Reflection;

namespace Six.Samples
{
    public static class Sampler
    {
        public static IEnumerable<Sample> LoadT1()
        {
            return LoadAll(name => name.EndsWith(".t1")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadT2()
        {
            return LoadAll(name => name.EndsWith(".t2")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadT3()
        {
            return LoadAll(name => name.EndsWith(".t3")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadT4()
        {
            return LoadAll(name => name.EndsWith(".t4")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadT5()
        {
            return LoadAll(name => name.EndsWith(".t5" +
                "")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadT6()
        {
            return LoadAll(name => name.EndsWith(".t6")).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> Load(string extension)
        {
            return LoadAll(name => name.EndsWith(extension)).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadSix()
        {
            return LoadAll(name => name.EndsWith(".six")).OrderBy(s => s.Name);
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

        public static IEnumerable<Sample> LoadCeylon()
        {
            return LoadCeylonLanguage().Concat(LoadCeylonSdk()).OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadCeylonSdk()
        {
            return LoadCeylon("sdk", @"D:\SixTmp\ceylon-sdk\source\ceylon").OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadCeylonLanguage()
        {
            return LoadCeylon("language", @"D:\SixTmp\ceylon\language\src\ceylon\language").OrderBy(s => s.Name);
        }

        public static IEnumerable<Sample> LoadCeylonOrdered()
        {
            return from s in LoadCeylon("language", @"D:\SixTmp\ceylon\language\src\ceylon\language")
                   where !s.Name.Contains(".meta.")
                   let x = Path.GetExtension(Path.GetFileNameWithoutExtension(s.Name))
                   where char.IsUpper(x[1]) && "A".Contains(x[1])
                   orderby x[1]
                   select s;
        }

        private static IEnumerable<Sample> LoadCeylon(string prefix, string root)
        {
            foreach (var filepath in Directory.EnumerateFiles(root, "*.ceylon", SearchOption.AllDirectories))
            {
                var name = prefix + filepath.Substring(root.Length).Replace('\\', '.');

                var sample = LoadFile(filepath, name);

                yield return sample;
            }
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

            var ext = Path.GetExtension(name);

            if (ext.Length == 3 && ext[1] == 't')
            {
                return new Sample(name, content, true);
            }

            return new Sample(name, content, false);
        }

        private static Sample LoadFile(string filepath, string? name = null)
        {
            var content = File.ReadAllText(filepath);
            name ??= Path.GetFileName(filepath);

            return new Sample(name, content, false);
        }
    }
}
