using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class FunctionTable : WithWriter
    {
        private readonly Dictionary<string, (uint index, Decl.Function function)> table = new();

        public FunctionTable(Writer writer, string name)
            : base(writer)
        {
            Name = name;
        }

        public string Name { get; }

        public uint Add(Decl.Function function, string name)
        {
            uint index;
            if (!table.TryGetValue(name, out var entry))
            {
                index = (uint)table.Count;
                table.Add(name, (index, function));
            }
            else
            {
                index = entry.index;
            }

            return index;
        }

        public void Emit()
        {
            if (table.Count > 0)
            {
                wl($"(table {Name} anyfunc (elem");
                indent(() =>
                {
                    foreach (var (name, element) in table.OrderBy(kv => kv.Value.index))
                    {
                        wl($"${name}");
                    }
                });
                wl("))");
            }
        }
    }
}
