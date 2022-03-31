using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFunctionTable : WithWriter, Wamber
    {
        private readonly Dictionary<string, (uint index, WaFunction function)> table = new();

        public WaFunctionTable(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
        }

        public WaModule Module { get; }
        public string Name { get; }

        public uint Add(WaFunction function, string name)
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

        public void Prepare()
        {
        }

        public void Emit()
        {
            if (table.Count > 0)
            {
                wl($"(table ${Name} funcref (elem");
                indent(() =>
                {
                    foreach (var (name, element) in table.OrderBy(kv => kv.Value.index))
                    {
                        wl($"(; {element.index:X4} ;) (ref.func ${name})");
                    }
                });
                wl("))");
            }
        }
    }
}
