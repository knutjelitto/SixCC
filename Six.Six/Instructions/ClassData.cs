using Six.Core;
using Six.Six.Builtins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class ClassData : EmitBase
    {
        private readonly Dictionary<string, (int order, Action emit, Func<Ptr> access)> metas = new();

        public ClassData(Emitter emitter, string memoryId)
            : base(emitter.Writer)
        {
            Emitter = emitter;
            MemoryId = memoryId;
        }

        public Emitter Emitter { get; }
        public string MemoryId { get; }
        public uint Offset { get; private set; }
        public uint BaseOffset { get; private set; }
        public uint Next => BaseOffset + Offset;

        public Func<Ptr> Add(ClassLayout layout)
        {
            var start = Dispatch(layout);

            var text = layout.Classy.FullName;

            if (!metas.TryGetValue(text, out var already))
            {
                Assert(Offset == AlignCount(Offset));

                var stringPtr = Emitter.AddString(text);

                var offset = Offset;

                void emit()
                {
                    wl($"(; +{BaseOffset + offset:X4} - {text} ;)");
                    indent(() =>
                    {
                        wl($"(; clazz          ;) {EmitUInt32(0)}");
                        wl($"(; clazz-dispatch ;) {EmitUInt32(0)}");
                        wl($"(; size           ;) {EmitUInt32(layout.MetaSize)}");
                        wl($"(; name           ;) {EmitPtr(stringPtr())}");
                        wl($"(; dispatch       ;) {EmitUInt32(start)}");
                    });
                }

                Ptr access()
                {
                    return new Ptr(BaseOffset + offset);
                }

                metas.Add(text, (metas.Count, emit, access));

                Offset = AlignCount((uint)(Offset + WasmDef.Pointer.Size + WasmDef.I32.Size + WasmDef.I32.Size + WasmDef.Pointer.Size + WasmDef.I32.Size));

                return access;
            }

            return already.access;
        }

        private uint Dispatch(ClassLayout layout)
        {
            var start = Emitter.DispatchTable.Current;

            foreach (var slot in layout.Slots)
            {
                Emitter.DispatchTable.Add(slot.Funcy);
            }

            return start;
        }

        public void Emit(uint baseOffset)
        {
            Assert(AlignCount(baseOffset) == baseOffset);

            BaseOffset = baseOffset;

            wl($"(data (memory ${MemoryId}) (offset {Insn.U32.Const(BaseOffset)})");
            indent(() =>
            {
                foreach (var (_, emit, _) in metas.Values.OrderBy(e => e.order))
                {
                    emit();
                }
            });
            wl(")");
        }
    }
}
