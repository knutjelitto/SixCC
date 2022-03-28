using Six.Core;
using Six.Six.Builtins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class StringData : EmitBase
    {
        private readonly Dictionary<string, (int order, Action emit, Func<Ptr> access)> strings = new();

        public StringData(Emitter emitter, string memoryId)
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

        public Func<Ptr> Add(string text)
        {
            if (!strings.TryGetValue(text, out var already))
            {
                Assert(Offset == AlignCount(Offset));
                var bytes = Encoding.UTF8.GetBytes(text);
                var count = (uint)bytes.Length;
                var offset = Offset;

                void emit()
                {
                    wl($"(; +{BaseOffset + offset:D4} ;) {EmitUInt32(count)} {EmitUtf8(bytes)}");
                }

                Ptr access()
                {
                    return new Ptr(BaseOffset + offset);
                }

                strings.Add(text, (strings.Count, emit, access));

                Offset = AlignCount(Offset + WasmDef.I32.Size + count);

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
                foreach (var (_, emit, _) in strings.Values.OrderBy(e => e.order))
                {
                    emit();
                }
            });
            wl(")");
        }
    }
}
