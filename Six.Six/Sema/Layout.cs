using Six.Six.Builtins;

namespace Six.Six.Sema
{
    public class Layout
    {
        private readonly List<Decl.Field> fields = new();
        private bool done = false;

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

        public void Run()
        {
            if (done)
            {
                return;
            }

            uint fieldOffset = 0;

            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Run();

                fieldOffset = Classy.Extends.Layout.Size;
            }

            foreach (var member in Classy.Members)
            {
                switch (member)
                {
                    case Decl.Field field:
                        fields.Add(field);
                        break;
                    case Decl.Attribute attribute:
                        break;
                    case Decl.Function function:
                        break;
                    case Decl.Constructor constructor:
                        break;
                    default:
                        Assert(false);
                        throw new System.NotImplementedException();
                }
            }

            foreach (var field in fields)
            {
                var type = Resolver.LowerType(field.Type);

                if (type is Builtin builtin)
                {
                    fieldOffset = builtin.Wasm.Align(fieldOffset);

                    field.Offset = fieldOffset;

                    fieldOffset += builtin.Wasm.MemSize;
                }
                else
                {
                    Assert(false);
                }
            }

            Size = fieldOffset;

            done = true;
        }
    }
}
