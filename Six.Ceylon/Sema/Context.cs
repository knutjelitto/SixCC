using Six.Ceylon.Walking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Sema
{
    public class Context
    {
        private readonly Dictionary<string, HashSet<string>> imports = new();

        public Context()
        {
            Root = new NamespaceScope(null, "");
            Current = Root;
            Reflector = new Reflector();
        }

        public NamespaceScope Root { get; }
        public IScope Current { get; set; }
        public Reflector Reflector { get; }

        public IDisposable Push(IScope scope)
        {
            var savedCurrent = Current;
            Current = scope;

            return new Disposable(
                () =>
                {
                    Current = savedCurrent;
                });
        }

        public void AddImport(string path, string location)
        {
            if (!path.StartsWith("six.core"))
            {
                if (!imports.TryGetValue(path, out var locations))
                {
                    locations = new HashSet<string>();
                    imports.Add(path, locations);
                }
                locations.Add(location);
            }
        }

        public void DumpImports(Writer writer)
        {
            if (imports.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("raw imports:");
                using (writer.Indent())
                {
                    foreach (var path in imports.Keys)
                    {
                        writer.WriteLine(path);
                        using (writer.Indent())
                        {
                            foreach (var location in imports[path].OrderBy(i => i))
                            {
                                writer.WriteLine(location);
                            }
                        }
                    }
                }
            }
        }
    }
}
