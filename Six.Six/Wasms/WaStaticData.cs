using Six.Runtime;
using Six.Six.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaStaticData : WaListOf<WaStaticField>
    {
        public WaStaticData(WaModule module, string memoryName)
            : base(module)
        {
            Module = module;
            MemoryName = memoryName;
        }

        public WaModule Module { get; }
        public string MemoryName { get; }
        public uint BaseOffset { get; set; } = uint.MaxValue;
        public uint Size { get; private set; } = 0;

        public override void Prepare()
        {
            Assert(BaseOffset < uint.MaxValue);
            Assert(BaseOffset == Align16(BaseOffset));

            var offset = BaseOffset;

            Assert(offset == Align16(offset));

            foreach (var field in this)
            {
                var newOffset = field.Type.Align(offset);
                if (newOffset > offset)
                {
                    wl(EmitZeros(newOffset - offset));
                }
                offset = newOffset;

                field.Address = offset;

                offset = field.Address + field.Size;

                field.Prepare();
            }

            Size = Align16(offset) - BaseOffset;
        }

        public override void Emit()
        {
            Assert(BaseOffset < uint.MaxValue);

            wl($"(data (memory ${MemoryName}) (offset {Insn.U32.Const(BaseOffset)})");
            indent(() =>
            {
                foreach (var field in this)
                {
                    field.Emit();
                }
            });
            wl(")");
        }
    }
}
