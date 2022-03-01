using Six.Six.Builtins;
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
        public Expr.Concrete NaturalConst(A.Expression.NaturalNumber tree)
        {
            Builtin builtin;

            var value = ConvertNatural(tree.Text);

            if (value > long.MaxValue)
            {
                builtin = Builtin.Resolve(Module.Core.UInt64);
                return new Expr.ConstU64(builtin, value);
            }
            else if (value > int.MaxValue)
            {
                builtin = Builtin.Resolve(Module.Core.Int64);
                return new Expr.ConstI64(builtin, (long)value);
            }
            else
            {
                builtin = Builtin.Resolve(Module.Core.Int32);
                return new Expr.ConstI32(builtin, (int)value);
            }
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
