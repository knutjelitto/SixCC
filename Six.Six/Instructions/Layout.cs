using Six.Six.Builtins;
using Six.Six.Sema;
using System.Collections;

namespace Six.Six.Instructions
{
    public class Layout
    {
        public readonly FieldList Fields = new();
        public readonly SlotList Slots = new();
        public readonly List<IFace> IFaces = new();

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

        protected void Prefill(SlotList subSlots)
        {
            Run();

            foreach (var slot in Slots.Slots)
            {
                subSlots.Add(slot);
            }
        }

        private void MakeFields()
        {
            var fieldOffset = WasmDef.Pointer.Size;

            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Run();
                Fields.AddRange(Classy.Extends.Layout.Fields);
                fieldOffset = Classy.Extends.Layout.Size;
            }

            foreach (var field in Classy.Fields)
            {
                Fields.Add(field);
            }

            foreach (var field in Fields)
            {
                var builtin = Emitter.Lower(field.Field.Type);

                fieldOffset = builtin.Wasm.Align(fieldOffset);

                field.Field.Offset = fieldOffset;

                fieldOffset += builtin.Wasm.MemSize;
            }

            Size = fieldOffset;
        }

        private void MakeSlots()
        {
            if (Classy.Extends != null)
            {
                Classy.Extends.Layout.Prefill(Slots);
            }

            foreach (var iface in Classy.Satisfies.Closure())
            {
                IFaces.Add(new IFace(Classy, iface));
            }

            foreach (var member in Classy.Block.Members)
            {
                switch (member)
                {
                    case Decl.Field:
                        break;
                    case Decl.Attribute attribute:
                        Slots.AddOrUpdate(attribute);
                        break;
                    case Decl.Function function:
                        Slots.AddOrUpdate(function);
                        break;
                    case Decl.Constructor constructor:
                        Slots.AddOrUpdate(constructor);
                        break;
                    default:
                        Assert(false);
                        throw new System.NotImplementedException();
                }
            }

        }

        public class IFace
        {
            public readonly List<LSlot> Slots = new();

            public IFace(Decl.Classy classy, Decl.Interface iface)
            {
                Classy = classy;
                Interface = iface;
            }

            public Decl.Classy Classy { get; }
            public Decl.Interface Interface { get; }
            public string Name => Interface.Name;

            public string FullName => $"{Classy.FullName}@{Interface.FullName}";
        }

        public class LField
        {
            public LField(Decl.Field field)
            {
                Field = field;
            }

            public Decl.Field Field { get; }
        }

        public class FieldList : IReadOnlyList<LField>
        {
            public readonly List<LField> Fields = new();

            public void Add(Decl.Field field)
            {
                Fields.Add(new LField(field));
            }

            public void Add(LField field)
            {
                Fields.Add(field);
            }

            public void AddRange(IEnumerable<LField> fields)
            {
                Fields.AddRange(fields);
            }

            public LField this[int index] => Fields[index];
            public int Count => Fields.Count;
            public IEnumerator<LField> GetEnumerator() => Fields.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Fields).GetEnumerator();
        }

        public class LSlot
        {
            public LSlot(int index, Decl.Funcy funcy)
            {
                Index = index;
                Funcy = funcy;
            }

            public int Index { get; }
            public Decl.Funcy Funcy { get; }
        }

        public class SlotList : IReadOnlyList<LSlot>
        {
            public readonly List<LSlot> Slots = new();


            public void Add(LSlot slot)
            {
                Slots.Add(slot);
            }

            public void AddOrUpdate(Decl.Funcy funcy)
            {
                var already = Slots.Where(s => s.Funcy.Name == funcy.Name).FirstOrDefault();
                if (already != null)
                {
                    Slots[already.Index] = new LSlot(already.Index, funcy);
                }
                else
                {
                    Slots.Add(new LSlot(Slots.Count, funcy));
                }
            }

            public LSlot this[int index] => Slots[index];
            public int Count => Slots.Count;
            public IEnumerator<LSlot> GetEnumerator() => Slots.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Slots).GetEnumerator();
        }
    }
}
