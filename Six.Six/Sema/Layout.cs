using Six.Six.Builtins;

namespace Six.Six.Sema
{
    public class Layout
    {
        private readonly List<Decl.Field> fields = new();

        public Layout(Decl.Classy classy)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
        public Module Module => Classy.Container.Module;
        public Resolver Resolver => Module.Resolver;

        public uint Size { get; private set; } = uint.MaxValue;

        public void Add(Decl.Field declaredField)
        {
            fields.Add(declaredField);
        }

        public void Finish()
        {
            uint offset = 0;

            foreach (var field in fields)
            {
                var type = Resolver.LowerType(field.Type);

                if (type is Builtin builtin)
                {
                    offset = builtin.Wasm.Align(offset);
                    field.Offset = offset;

                    offset += builtin.Wasm.MemSize;
                }
                else
                {
                    Assert(false);
                }
            }

            Size = offset;
        }
    }
}
