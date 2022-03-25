using Six.Six.Builtins;
using Six.Six.Sema;
using System.Collections;

namespace Six.Six.Instructions
{
    public class Layout
    {
        public readonly FieldList Fields = new();
        public readonly SlotList Slots = new();
        public readonly InterFaceList InterFaces = new();

        public Layout(Decl.Classy classy)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
        public Module Module => Classy.Block.Module;
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
            MakeInterfaces();
            RetroSlots();

            Emitter.AddClass(Classy.FullName, Size);
        }

        private void MakeFields()
        {
            var fieldOffset = WasmDef.Pointer.Size;

            if (Classy.Extends is Decl.Class extended)
            {
                extended.Layout.Run();
                Fields.AddRange(extended.Layout.Fields);
                fieldOffset = extended.Layout.Size;
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
            if (Classy.Extends is Decl.Class extended)
            {
                extended.Layout.Run();
                Slots.AddRange(extended.Layout.Slots);
            }

            foreach (var funcy in Classy.Block.Members.OfType<Decl.Funcy>())
            {
                Slots.AddOrUpdate(funcy);
            }
        }

        private void MakeInterfaces()
        {
            foreach (var iface in Classy.Closure())
            {
                iface.Layout.Run();
                InterFaces.Add(Classy, iface);
            }

            foreach (var interFace in InterFaces)
            {
                interFace.Slots.AddRange(interFace.Interface.Layout.Slots);

                foreach (var islot in interFace.Slots.ToList())
                {
                    var cslot = Slots
                        .Where(s => s.Funcy.Name == islot.Funcy.Name)
                        .Where(s => s.Funcy.IsConcrete)
                        .SingleOrDefault();

                    if (cslot != null)
                    {
                        interFace.Slots.Set(islot.Index, cslot);
                    }
                }
            }
        }

        private void RetroSlots()
        {
            foreach (var slot in Slots.ToList())
            {
                if (slot.Funcy.IsAbstract)
                {
                    var interFaceSlots = InterFaces
                        .SelectMany(iface => iface.Slots)
                        .Where(islot => islot.Funcy.IsConcrete && islot.Funcy.Name == slot.Funcy.Name)
                        .ToList();

                    if (interFaceSlots.Count == 1)
                    {
                        Slots.Set(slot.Index, interFaceSlots[0]);
                    }
                }
            }
        }

        public class InterFace
        {
            public readonly SlotList Slots = new();

            public InterFace(Decl.Classy classy, Decl.Interface iface)
            {
                Classy = classy;
                Interface = iface;
            }

            public Decl.Classy Classy { get; }
            public Decl.Interface Interface { get; }
            public string Name => Interface.Name;

            public string FullName => $"{Classy.FullName}@{Interface.FullName}";

            public override string ToString()
            {
                return FullName;
            }
        }

        public class InterFaceList : IReadOnlyList<InterFace>
        {
            public List<InterFace> IFaces = new();

            public void Add(Decl.Classy classy, Decl.Interface @interface)
            {
                IFaces.Add(new InterFace(classy, @interface));
            }

            public InterFace this[int index] => IFaces[index];
            public int Count => IFaces.Count;
            public IEnumerator<InterFace> GetEnumerator() => IFaces.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)IFaces).GetEnumerator();
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

            public override string ToString()
            {
                return Funcy.FullName;
            }
        }

        public class SlotList : IReadOnlyList<LSlot>
        {
            public readonly List<LSlot> Slots = new();

            public void Set(int index, LSlot slot)
            {
                Slots[index] = slot;
            }

            public void Add(LSlot slot)
            {
                Slots.Add(slot);
            }

            public void AddRange(IEnumerable<LSlot> slots)
            {
                Slots.AddRange(slots);
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
