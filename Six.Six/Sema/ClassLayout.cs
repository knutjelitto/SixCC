using System.Collections;

using Six.Six.Instructions;
using Six.Six.Wasms;

namespace Six.Six.Sema
{
    public class ClassLayout
    {
        public readonly FieldList Fields = new();
        public readonly SlotList Slots = new();
        public readonly InterFaceList InterFaces = new();

        public ClassLayout(Decl.Classy classy)
        {
            Classy = classy;

            Run();
        }

        public Decl.Classy Classy { get; }
        public Module Module => Classy.Block.Module;
        public Resolver Resolver => Module.Resolver;
        public TypeResolver TypeResolver => Module.Resolver.T;

        public uint MetaSize { get; private set; } = uint.MaxValue;

        private void Run()
        {
            MakeFields();
            MakeSlots();
            MakeInterfaces();
            RetrofitSlots();
        }

        private void MakeFields()
        {
            var fieldOffset = WasmType.Addr.Size + WasmType.I32.Size;

            if (Classy.Extends is Decl.Class extended)
            {
                Fields.AddRange(extended.Layout.Fields);
                fieldOffset = extended.Layout.MetaSize;
            }

            foreach (var field in Classy.Fields)
            {
                Fields.Add(field);
            }

            foreach (var field in Fields)
            {
                var builtin = TypeResolver.Lower(field.Type);

                fieldOffset = builtin.MemAlign(fieldOffset);

                field.Offset = fieldOffset;

                fieldOffset = builtin.MemAlign(fieldOffset + 1);
            }

            MetaSize = fieldOffset;
        }

        private void MakeSlots()
        {
            if (Classy.Extends is Decl.Class extended)
            {
                Slots.AddRange(extended.Layout.Slots);
            }

            bool SlotMember(Decl.Funcy f)
            {
                return f.IsDynamic
                    || Classy is Decl.Interface && !f.IsStatic;
            }

            foreach (var funcy in Classy.Members.Functions.Where(f => SlotMember(f)))
            {
                Slots.AddOrUpdate(funcy);
            }
        }

        private void MakeInterfaces()
        {
            foreach (var iface in Classy.Closure())
            {
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

        private void RetrofitSlots()
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

        public class FieldList : IReadOnlyList<Decl.Field>
        {
            public readonly List<Decl.Field> Fields = new();

            public void Add(Decl.Field field)
            {
                Fields.Add(field);
            }

            public void AddRange(IEnumerable<Decl.Field> fields)
            {
                Fields.AddRange(fields);
            }

            public Decl.Field this[int index] => Fields[index];
            public int Count => Fields.Count;
            public IEnumerator<Decl.Field> GetEnumerator() => Fields.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Fields).GetEnumerator();
        }

        public class DispatchSlot
        {
            public DispatchSlot(int index, Decl.Funcy funcy)
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

        public class SlotList : IReadOnlyList<DispatchSlot>
        {
            public readonly List<DispatchSlot> Slots = new();

            public void Set(int index, DispatchSlot slot)
            {
                Slots[index] = slot;
            }

            public void Add(DispatchSlot slot)
            {
                Slots.Add(slot);
            }

            public void AddRange(IEnumerable<DispatchSlot> slots)
            {
                Slots.AddRange(slots);
            }

            public void AddOrUpdate(Decl.Funcy funcy)
            {
                var already = Slots.Where(s => s.Funcy.Name == funcy.Name).FirstOrDefault();
                if (already != null)
                {
                    Slots[already.Index] = new DispatchSlot(already.Index, funcy);
                }
                else
                {
                    Slots.Add(new DispatchSlot(Slots.Count, funcy));
                }
            }

            public DispatchSlot this[int index] => Slots[index];
            public int Count => Slots.Count;
            public IEnumerator<DispatchSlot> GetEnumerator() => Slots.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Slots).GetEnumerator();
        }
    }
}
