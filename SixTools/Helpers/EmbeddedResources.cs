using SixTools.Grammars;
using System.Reflection;

namespace SixTools
{
    public static class EmbeddedResources
    {
        public static void List()
        {
            foreach (var name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine($"sample: {name}");
            }
        }

        public static string GetSample(string name)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{typeof(Samples).FullName}.{name}"))
            {
                if (stream != null)
                {
                    using var reader = new StreamReader(stream);
                    return reader.ReadToEnd();
                }
            }
            return string.Empty;
        }

        public static TextReader? GetCss(Type type)
        {
            var stream = type.Assembly.GetManifestResourceStream($"{type.FullName}.css");
            return stream != null
                ? new StreamReader(stream)
                : null;
        }

        public static void GetCss(Writer writer, Type type)
        {
            using (var stream = GetCss(type))
            {
                if (stream != null)
                {
                    string? line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                    return;
                }
            }
        }
    }
}
