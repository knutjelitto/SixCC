using Six.Runtime;
using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public class DispatchTable : WithWriter
    {
        private readonly List<Decl.Funcy> table = new();

        public DispatchTable(Emitter emitter, string name)
            : base(emitter.Writer)
        {
            Emitter = emitter;
            Name = name;
        }

        public Emitter Emitter { get; }
        public string Name { get; }

        public uint Current => (uint)table.Count;

        public void Add(Decl.Funcy function)
        {
            Assert(function is Decl.Function or Decl.Attribute);
            Add(function, function.FullName);
        }

        public void Add(Decl.Funcy function, string name)
        {
            table.Add(function);
        }

        public void Emit()
        {
            if (table.Count > 0)
            {
                wl($"(table ${Name} funcref (elem");
                indent(() =>
                {
                    for (var i = 0; i < table.Count; i++)
                    {
                        var funcy = table[i];
                        wl($"(; {i:X4} ;) (ref.func ${funcy.FullName})");
                    }
                });
                wl("))");
            }
        }
    }
}
