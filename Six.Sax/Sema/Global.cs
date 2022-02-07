using Six.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Sema
{
    public class Global
    {
        public Global()
        {
            Root = new NamespaceScope(null, "");
        }

        public NamespaceScope Root { get; }

        public NamespaceScope Open(IEnumerable<string> names)
        {
            var current = Root;
            foreach (var name in names)
            {
                current = current.Open(name);
            }
            return current;
        }

        public void Dump(Writer writer)
        {
            Root.Dump(writer);
        }
    }
}
