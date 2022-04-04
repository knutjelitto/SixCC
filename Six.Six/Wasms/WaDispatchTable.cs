using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public class WaDispatchTable : WithWriter, Wamber
    {
        private List<WaDispatches> items = new();

        public WaDispatchTable(WaModule module, string tableName)
            : base(module.Writer)
        {
            Module = module;
            TableName = tableName;
        }

        public WaModule Module { get; }
        public string TableName { get; }

        public void Add(WaDispatches dispatches)
        {
            items.Add(dispatches);
        }

        public void Prepare()
        {
            var index = 0;

            var consolidatedList = new List<WaDispatches>();

            foreach (var dispatches in items)
            {
                var theSame = false;

                foreach (var consolidated in consolidatedList)
                {
                    if (dispatches.AreTheSame(consolidated))
                    {
                        theSame = true;
                        break;
                    }
                }

                if (!theSame)
                {
                    consolidatedList.Add(dispatches);
                }
            }

            foreach (var dispatches in items)
            {
                dispatches.Index = index;
                dispatches.Prepare();
                index += dispatches.Count;
            }
        }

        public void Emit()
        {
            if (items.Count > 0)
            {
                wl($"(table ${TableName} funcref (elem");
                indent(() =>
                {
                    foreach (var dispatches in items)
                    {
                        dispatches.Emit();
                    }
                });
                wl("))");
            }
        }
    }
}
