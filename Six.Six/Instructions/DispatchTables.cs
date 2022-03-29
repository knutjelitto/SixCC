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
    public class DispatchTables : WithWriter
    {
        private readonly Dictionary<string, (int order, DispatchTable table)> tables = new();

        public DispatchTables(Emitter emitter)
            : base(emitter.Writer)
        {
            Emitter = emitter;
        }

        public Emitter Emitter { get; }

        public void Add(Decl.Classy classy)
        {
            var name = Module.DispatchName(classy);

            if (tables.ContainsKey(name))
            {
                return;
            }

            var table = new DispatchTable(Emitter, name);

            foreach (var slot in classy.Layout.Slots)
            {
                table.Add(slot.Funcy);
            }

            tables.Add(name, (tables.Count, table));
        }

        public void Emit()
        {
            foreach (var table in tables.Values.OrderBy(v => v.order).Select(v => v.table))
            {
                table.Emit();
            }
        }
    }
}
