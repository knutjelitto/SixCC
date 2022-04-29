using Six.Runtime;
using Six.Six.Instructions;

using static Six.Six.Wasms.WasmAlign;

namespace Six.Six.Wasms
{
    public class WaStringData : WithWriter, Wamber
    {
        private readonly Dictionary<string, WaConstString> strings = new();

        public WaStringData(WaModule module, string memoryName)
            : base(module.Writer)
        {
            Module = module;
            MemoryName = memoryName;
        }

        public WaModule Module { get; }
        public string MemoryName { get; }
        public uint BaseOffset { get; set; } = uint.MaxValue;
        public uint Size { get; private set; } = 0;

        public WaConstString Add(string text)
        {
            if (!strings.TryGetValue(text, out var constString))
            {
                constString = new WaConstString(this, strings.Count, text);
                strings.Add(text, constString);
            }

            return constString;
        }

        public void Prepare()
        {
            Assert(BaseOffset < uint.MaxValue);
            Assert(BaseOffset == Align16(BaseOffset));

            var offset = WaPtr.Null.Offset(BaseOffset);

            foreach (var constString in strings.Values.OrderBy(s => s.Order))
            {
                constString.Address = offset;

                offset = WaPtr.Null.Offset(Align8(constString.Address.Address + constString.Size));

                constString.NextAddress = offset;

                constString.Prepare();
            }

            Size = Align16(offset.Address) - BaseOffset;
        }

        public void Emit()
        {
            wl($"(data (memory ${MemoryName}) (offset {Insn.U32.Const(BaseOffset)})");
            indent(() =>
            {
                foreach (var stringConstant in strings.Values.OrderBy(e => e.Order))
                {
                    stringConstant.Emit();
                }
            });
            wl(")");
        }
    }
}
