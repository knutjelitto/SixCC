using System.Reflection;

namespace Six.Runtime
{
    public class Loader
    {
        public static string LoadEmbedded(Assembly assembly, string resourceName)
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
