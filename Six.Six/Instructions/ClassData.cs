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

        public Func<Ptr> Add(string text, uint size)
        {
            if (!metas.TryGetValue(text, out var already))
            {
                Assert(Offset == AlignCount(Offset));

                var stringPtr = Emitter.AddString(text);

                var offset = Offset;

                void emit()
                {
                    wl($"(; +{BaseOffset + offset:D4} - {text,-25} ;) {EmitUInt32(size)} {EmitPtr(stringPtr())}");
                }

                Ptr access()
                {
                    return new Ptr(BaseOffset + offset);
                }

                metas.Add(text, (metas.Count, emit, access));

                Offset = AlignCount(Offset + WasmDef.I32.Size + WasmDef.Pointer.Size);

                return access;
            }

            return already.access;
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
