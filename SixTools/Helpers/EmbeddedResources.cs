using Six.Core;
using SixTools.Grammars;
using System.Reflection;

namespace SixTools.Helpers
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

        public static TextReader? GetCss(string name)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{name}.css");
            return stream != null
                ? new StreamReader(stream)
                : null;
        }

        public static void GetCss(Writer writer, Type type)
        {
            using var stream = GetCss(type.FullName!);
            if (stream != null)
            {
                string? line;
                while ((line = stream.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public static void GetCss(Writer writer, string name)
        {
            using var stream = GetCss(name);
            if (stream != null)
            {
                string? line;
                while ((line = stream.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        writer.WriteLine();
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
