using Six.Six.Builtins;
using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public class Layout
    {
        public readonly List<Decl.Field> Fields = new();
        public readonly List<Decl.Funcy> Funcy = new();

        public Layout(Decl.Classy classy)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
        public Module Module => Classy.Container.Module;
        public Resolver Resolver => Module.Resolver;
        public Emitter Emitter => Module.Emitter;

        public uint Size { get; private set; } = uint.MaxValue;
        public bool Done { get; private set; }

        public void Add(Decl.Field declaredField)
        {
            Fields.Add(declaredField);
        }

        public void Run()
        {
            if (Done)
            {
                return;
            }

            MakeFields();

            Emitter.AddClass(Classy.FullName, Size);

            Done = true;
        }

        private void MakeFields()
        {
            var fieldOffset = WasmDef.Pointer.Size;

            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Run();

                fieldOffset = Classy.Extends.Layout.Size;
            }

            foreach (var member in Classy.Block.Members)
            {
                switch (member)
                {
                    case Decl.Field field:
                        Fields.Add(field);
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

            foreach (var field in Fields)
            {
                var type = Resolver.LowerType(field.Type);

                if (type is Builtin builtin)
                {
                    fieldOffset = builtin.Wasm.Align(fieldOffset);

                    field.Offset = fieldOffset;

                    fieldOffset += builtin.Wasm.MemSize;
                }
                else if (type is Type.ClassReference clazz)
                {
                    Assert(true);
                }
                else
                {
                    Assert(false);
                }
            }

            Size = fieldOffset;

        }
    }
}
