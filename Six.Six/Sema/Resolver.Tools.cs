using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        public Expr NaturalConst(A.Expression.NaturalNumber tree)
        {
            var text = ExtractSuffix(tree, out var suffix);

            var value = ConvertNatural(text);

            switch (suffix)
            {
                case "i32":
                    return new Expr.ConstI32(Module.CoreFindType(Names.Core.Int32), (int)value);
                case "i64":
                    return new Expr.ConstI64(Module.CoreFindType(Names.Core.Int64), (long)value);
                case "u32":
                    return new Expr.ConstU32(Module.CoreFindType(Names.Core.UInt32), (uint)value);
                case "u64":
                    return new Expr.ConstU64(Module.CoreFindType(Names.Core.UInt64), (ulong)value);
                case "":
                    if (value > long.MaxValue)
                    {
                        return new Expr.ConstU64(Module.CoreFindType(Names.Core.UInt64), value);
                    }
                    else if (value > int.MaxValue)
                    {
                        if (value > uint.MaxValue)
                        {
                            return new Expr.ConstI64(Module.CoreFindType(Names.Core.Int64), (long)value);
                        }
                        return new Expr.ConstU32(Module.CoreFindType(Names.Core.UInt32), (uint)value);
                    }
                    else
                    {
                        return new Expr.ConstI32(Module.CoreFindType(Names.Core.Int32), (int)value);
                    }
                default:
                    Assert(false);
                    throw new NotImplementedException();
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
                Assert('0' <= c && c <= '9' || 'a' <= c && c <= 'f' || 'A' <= c && c <= 'F');
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


        private string ExtractSuffix(A.Expression.NaturalNumber tree, out string suffix)
        {
            var text = tree.Text;

            var si = text.IndexOf('i');
            if (si > 0)
            {
                suffix = text[si..];
                return text[..si];
            }
            var su = text.IndexOf('u');
            if (su > 0)
            {
                suffix = text[su..];
                return text[..su];
            }

            suffix = "";
            return text;
        }

        public Expr PlainString(A.Expression.String.Plain tree)
        {
            var type = Module.CoreFindType(Names.Core.String);

            return new Expr.ConstString(type, tree.Text);
        }
    }
}
