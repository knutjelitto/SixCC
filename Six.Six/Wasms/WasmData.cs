using System;

using Six.Six.Instructions;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Wasms
{
    public static class WasmData
    {
        public static uint Align16(uint offset)
        {
            return WasmType.Align(16, offset);
        }

        public static uint Align(uint align, uint offset)
        {
            return WasmType.Align(align, offset);
        }

        public static uint AlignPointer(uint offset)
        {
            return WasmType.Ptr.Align(offset);
        }

        public static uint AlignCount(uint offset)
        {
            return WasmType.I32.Align(offset);
        }

        public static string CvtByte(byte value)
        {
            return $"\\{value:X2}";
        }

        public static string CvtBytes(byte[] bytes)
        {
            return string.Join("", bytes.Select(b => CvtByte(b)));
        }

        public static string EmitBytes(byte[] bytes)
        {
            return $"\"{CvtBytes(bytes)}\"";
        }

        public static string EmitPtr(Ptr value)
        {
            var bytes = BitConverter.GetBytes(value.Value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public static string EmitAddress(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public static string EmitUInt32(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public static string EmitInt32(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public static string EmitZeros(uint count)
        {
            var builder = new StringBuilder();
            while (count > 0)
            {
                builder.Append(CvtByte(0));
                count--;
            }

            return $"\"{builder}\"";
        }

        public static string EmitUtf8(byte[] bytes)
        {
            var builder = new StringBuilder();
            foreach (var b in bytes)
            {
                switch (b)
                {
                    case 0x09:
                        builder.Append("\\t");
                        break;
                    case 0x0A:
                        builder.Append("\\n");
                        break;
                    case 0x0D:
                        builder.Append("\\r");
                        break;
                    case 0x22:
                        builder.Append("\\\"");
                        break;
                    case 0x27:
                        builder.Append("\\'");
                        break;
                    case 0x5C:
                        builder.Append("\\\\");
                        break;
                    default:
                        if (b >= 0x20 && b < 0x7F)
                        {
                            builder.Append((char)b);
                        }
                        else
                        {
                            builder.Append(CvtByte(b));
                        }
                        break;
                }
            }
            return $"\"{builder}\"";
        }
    }
}
