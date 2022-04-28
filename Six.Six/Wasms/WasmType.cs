using Six.Six.Instructions;

namespace Six.Six.Wasms
{
    public class WaCoreType
    {
        public static readonly WaCoreType I32 = new("i32", 4);
        public static readonly WaCoreType I64 = new("i64", 8);
        public static readonly WaCoreType F32 = new("f32", 4);
        public static readonly WaCoreType F64 = new("f64", 8);

        private WaCoreType(string name, uint? size = null)
        {
            Name = name;
            Size = size;
        }

        public string Name { get; }
        public uint? Size { get; }
    }

    public class WasmType
    {
        public static readonly WasmType Addr = new Address();
        public static readonly WasmType Void = new("VOID", 0, 0, 0);
        public static readonly WasmType Bool = new("i32", 4, 1, 1);
        public static readonly WasmType I32 = new("i32", 4, 4, 4);
        public static readonly WasmType I32_8 = new("i32", 4, 1, 1);
        public static readonly WasmType I32_16 = new("i32", 4, 2, 2);
        public static readonly WasmType I64 = new("i64", 8, 8, 8);
        public static readonly WasmType I64_8 = new("i64", 8, 1, 1);
        public static readonly WasmType I64_16 = new("i64", 8, 2, 2);
        public static readonly WasmType I64_32 = new("i64", 8, 4, 4);
        public static readonly WasmType F32 = new("f32", 4, 4, 4);
        public static readonly WasmType F64 = new("f64", 8, 8, 8);

        private WasmType(string type, uint size, uint memSize, uint? memAlign = null)
        {
            Type = type;
            MemSize = memSize;
            MemAlign = memAlign ?? memSize;
            Size = size;
        }

        public string Type { get; }
        public uint MemSize { get; }
        public uint MemAlign { get; }
        public uint Size { get; }

        public uint Align(uint offset)
        {
            return WasmAlign.Align(MemAlign, offset);
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
