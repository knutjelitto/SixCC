using Six.Core;
using Six.Runtime;
using W = Six.Six.Wasms;
using System;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Instructions
{
    public class EmitBase : WithWriter
    {
        public EmitBase(Writer writer)
            : base(writer)
        {
        }

        public uint Align(uint align, uint offset)
        {
            return W.WasmType.Align(align, offset);
        }

        public uint AlignPointer(uint offset)
        {
            return W.WasmType.Ptr.Align(offset);
        }

        public uint AlignCount(uint offset)
        {
            return W.WasmType.I32.Align(offset);
        }

        public string CvtByte(byte value)
        {
            return $"\\{value:X2}";
        }

        public string CvtBytes(byte[] bytes)
        {
            return string.Join("", bytes.Select(b => CvtByte(b)));
        }

        public string EmitBytes(byte[] bytes)
        {
            return $"\"{CvtBytes(bytes)}\"";
        }

        public string EmitPtr(Ptr value)
        {
            var bytes = BitConverter.GetBytes(value.Value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public string EmitUInt32(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public string EmitInt32(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            Assert(bytes.Length == 4);
            return EmitBytes(bytes);
        }

        public string EmitUtf8(byte[] bytes)
        {
            var builder = new StringBuilder();
            foreach (var b in bytes)
            {
                switch(b)
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
