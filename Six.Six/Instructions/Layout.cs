using Six.Six.Builtins;
using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public class Layout
    {
        public readonly List<Decl.Field> Fields = new();
        public readonly List<CallSlot> Slots = new();

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
            Done = true;

            MakeFields();
            MakeSlots();

            Emitter.AddClass(Classy.FullName, Size);

        }

        protected void Prefill(List<Decl.Field> subFields)
        {
            Run();

            foreach (var field in Fields)
            {
                subFields.Add(field);
            }
        }

        protected void Prefill(List<CallSlot> subSlots)
        {
            Run();

            foreach (var slot in Slots)
            {
                subSlots.Add(slot);
            }
        }

        private void MakeFields()
        {
            var fieldOffset = WasmDef.Pointer.Size;

            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Prefill(Fields);

                fieldOffset = Classy.Extends.Layout.Size;
            }

            foreach (var field in Classy.Fields)
            {
                Fields.Add(field);
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
                    Assert(false);
                }
                else
                {
                    Assert(false);
                }
            }

            Size = fieldOffset;
        }

        private void MakeSlots()
        {
            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Prefill(Slots);
            }

            foreach (var member in Classy.Block.Members)
            {
                switch (member)
                {
                    case Decl.Field:
                        break;
                    case Decl.Attribute attribute:
                        Slots.Add(new CallSlot(Slots.Count, attribute));
                        break;
                    case Decl.Function function:
                        Slots.Add(new CallSlot(Slots.Count, function));
                        break;
                    case Decl.Constructor constructor:
                        Slots.Add(new CallSlot(Slots.Count, constructor));
                        break;
                    default:
                        Assert(false);
                        throw new System.NotImplementedException();
                }
            }
        }

        public class CallSlot
        {
            public CallSlot(int index, Decl.Funcy funcy)
            {
                Index = index;
                Funcy = funcy;
            }

            public int Index { get; }
            public Decl.Funcy Funcy { get; }
        }
    }
}
