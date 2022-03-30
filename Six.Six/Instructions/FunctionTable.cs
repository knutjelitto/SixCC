using Six.Core;
using Six.Runtime;
using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public class FunctionTable : WithWriter
    {
        private readonly Dictionary<string, (uint index, Decl.Funcy function)> table = new();

        public FunctionTable(Emitter emitter, string name)
            : base(emitter.Writer)
        {
            Emitter = emitter;
            Name = name;
        }

        public Emitter Emitter { get; }
        public string Name { get; }

        public uint Add(Decl.Funcy function)
        {
            Assert(function is Decl.Function or Decl.Attribute);
            return Add(function, function.FullName);
        }

        public uint Add(Decl.Funcy function, string name)
        {
            Assert(function is Decl.Function or Decl.Attribute);

            uint index;
            if (!table.TryGetValue(name, out var entry))
            {
                _ = Emitter.TypeFor(function);
                index = (uint)table.Count;
                table.Add(name, (index, function));
            }
            else
            {
                index = entry.index;
            }

            return index;
        }

        public void EmitTable()
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
