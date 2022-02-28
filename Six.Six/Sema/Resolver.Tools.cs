using Six.Six.Instructions;
using System;
using static System.Formats.Asn1.AsnWriter;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        public (Type, Insn) NaturalType(A.TreeNode tree, ulong value)
        {
            Decl decl;
            Insn insn;

            if (value > long.MaxValue)
            {
                decl = Module.CoreFind(tree, Module.Core.UInt64);
                insn = Insn.I64.Const(value);
            }
            else if (value > int.MaxValue)
            {
                decl = Module.CoreFind(tree, Module.Core.Int64);
                insn = Insn.I64.Const(value);
            }
            else
            {
                decl = Module.CoreFind(tree, Module.Core.Int32);
                insn = Insn.I32.Const((uint)value);
            }

            var type = new Type.Reference(decl);

            return (type, insn);
        }

        public ulong ConvertNatural(string text)
        {
            if (text.StartsWith('#'))
            {
                ulong value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 16 + (ulong)hexValue(c);
                }
                return value;
            }
            else if (text.StartsWith('$'))
            {
                ulong value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 2 + (ulong)binValue(c);
                }
                return value;
            }
            else
            {
                ulong value = 0;
                foreach (var c in text)
                {
                    value = value * 10 + (ulong)decValue(c);
                }
                return value;
            }

            int binValue(char c)
            {
                Assert('0' <= c && c <= '1');
                return c - '0';
            }

            int decValue(char c)
            {
                Assert('0' <= c && c <= '9');
                return c - '0';
            }

            int hexValue(char c)
            {
                Assert('0' <= c && c <= '9' || 'a' <= c && c <= 'f' || 'A' <= c && c <= 'A');
                if ('0' <= c && c <= '9')
                {
                    return c - '0';
                }
                if ('a' <= c && c <= 'f')
                {
                    return 10 + c - 'a';
                }
                return 10 + c - 'A';
            }
        }
    }
}
