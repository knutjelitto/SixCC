using Six.Core;
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

        public void EmitTable()
        {
            if (table.Count > 0)
            {
                wl($"(table ${Name} funcref (elem");
                indent(() =>
                {
                    foreach (var funcy in table)
                    {
                        wl($"(ref.func ${funcy.FullName})");
                    }
                });
                wl("))");
            }
        }
    }
}
