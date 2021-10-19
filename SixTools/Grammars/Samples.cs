using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTools.Grammars
{
    public class Samples
    {
        public void List()
        {
            Console.WriteLine($"{GetType().FullName}");
            foreach (var name in GetType().Assembly.GetManifestResourceNames())
            {
                Console.WriteLine($"sample: {name}");
            }
        }

        public string Get(string name)
        {
            using (var stream = GetType().Assembly.GetManifestResourceStream($"{GetType().FullName}.{name}"))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            return string.Empty;
        }
    }
}
