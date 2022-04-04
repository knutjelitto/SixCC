using Six.Six.Instructions;

namespace Six.Six.Wasms
{
    public class WasmType
    {
        public static readonly Address Addr = new();
        public static readonly WasmType Void = new("VOID", 0, 0, 0);
        public static readonly WasmType Bool = new("i32", 1, 1, 4);
        public static readonly WasmType I32 = new("i32", 4, 4, 4);
        public static readonly WasmType I64 = new("i64", 8, 8, 8);
        public static readonly WasmType F32 = new("f32", 4, 4, 4);
        public static readonly WasmType F64 = new("f64", 8, 8, 8);

        private WasmType(string type, uint memSize, uint memAlign, uint size)
        {
            Type = type;
            MemSize = memSize;
            MemAlign = memAlign;
            Size = size;
        }

        public string Type { get; }
        public uint MemSize { get; }
        public uint MemAlign { get; }
        public uint Size { get; }

        public int Align(int offset)
        {
            return (int)Align(MemAlign, (uint)offset);
        }

        public uint Align(uint offset)
        {
            return Align(MemAlign, offset);
        }

        public static uint Align(uint align, uint offset)
        {
            return (offset + (align - 1)) & ~(align - 1);
        }

        public override string ToString()
        {
            return Type;
        }

        public class Address : WasmType
        {
            public Address()
                : base("i32", 4, 4, 4)
            {
            }

            public Insn Load(uint offset) => Insn.U32.Load(offset);
            public Insn Store(uint offset) => Insn.U32.Store(offset);
        }
    }
}
