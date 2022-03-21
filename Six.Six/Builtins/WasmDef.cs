using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public class WasmDef
    {
        public static readonly WasmDef Pointer = new WasmDef("i32", 4, 4, 4);
        public static readonly WasmDef Boolean = new WasmDef("i32", 1, 1, 4);
        public static readonly WasmDef I32 = new WasmDef("i32", 4, 4, 4);
        public static readonly WasmDef I64 = new WasmDef("i64", 8, 8, 8);
        public static readonly WasmDef F32 = new WasmDef("f32", 4, 4, 4);
        public static readonly WasmDef F64 = new WasmDef("f64", 8, 8, 8);

        private WasmDef(string type, uint memSize, uint memAlign, uint size)
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

        public uint Align(uint offset)
        {
            return Align(MemAlign, offset);
        }
        public static uint Align(uint align, uint offset)
        {
            return (offset + (align - 1)) & ~(align - 1);
        }

    }
}
