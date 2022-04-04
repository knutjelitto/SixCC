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

            var value = ConvertNatural(tree, text);

            switch (suffix)
            {
                case "s32":
                    if (value > int.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstS32(Module.CoreFindType(Names.Core.S32), int.MaxValue);
                    }
                    return new Primitive.ConstS32(Module.CoreFindType(Names.Core.S32), (int)value);
                case "s64":
                    if (value > long.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstS64(Module.CoreFindType(Names.Core.S64), long.MaxValue);
                    }
                    return new Primitive.ConstS64(Module.CoreFindType(Names.Core.S64), (long)value);
                case "u32":
                    if (value > uint.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstU32(Module.CoreFindType(Names.Core.U32), uint.MaxValue);
                    }
                    return new Primitive.ConstU32(Module.CoreFindType(Names.Core.U32), (uint)value);
                case "u64":
                    if (value > ulong.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstU64(Module.CoreFindType(Names.Core.U64), ulong.MaxValue);
                    }
                    return new Primitive.ConstU64(Module.CoreFindType(Names.Core.U64), value);
                case "":
                    Assert(value <= ulong.MaxValue);

                    var types = new List<Type>();
                    if (value <= (ulong)sbyte.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.S8));
                    }
                    if (value <= byte.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.U8));
                    }
                    if (value <= (ulong)short.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.S16));
                    }
                    if (value <= ushort.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.U16));
                    }
                    if (value <= int.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.S32));
                    }
                    if (value <= uint.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.U32));
                    }
                    if (value <= long.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.S64));
                    }
                    if (value <= ulong.MaxValue)
                    {
                        types.Add(Module.CoreFindType(Names.Core.U64));
                    }
                    var max_float_int = ((ulong)1) << 24;
                    var max_double_int = ((ulong)1) << 53;

                    if (value <= max_float_int)
                    {
                        types.Add(Module.CoreFindType(Names.Core.F32));
                    }
                    if (value <= max_double_int)
                    {
                        types.Add(Module.CoreFindType(Names.Core.F64));
                    }
#if false
                    var type = new Type.Intersection(Module);
                    type.AddRange(types);
                    return new Expr.ConstNatural(type, value);
#else

                    if (value > long.MaxValue)
                    {
                        return new Primitive.ConstU64(Module.CoreFindType(Names.Core.U64), value);
                    }
                    else if (value > int.MaxValue)
                    {
                        if (value > uint.MaxValue)
                        {
                            return new Primitive.ConstS64(Module.CoreFindType(Names.Core.S64), (long)value);
                        }
                        return new Primitive.ConstU32(Module.CoreFindType(Names.Core.U32), (uint)value);
                    }
                    else
                    {
                        return new Primitive.ConstS32(Module.CoreFindType(Names.Core.S32), (int)value);
                    }
#endif
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }

        }

        public ulong ConvertNatural(A.Expression.NaturalNumber tree, string text)
        {
            if (text.StartsWith('#'))
            {
                decimal value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 16 + (ulong)hexValue(c);
                    if (value > ulong.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree));
                        return ulong.MaxValue;
                    }
                }
                return (ulong)value;
            }
            else if (text.StartsWith('$'))
            {
                decimal value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 2 + (ulong)binValue(c);
                    if (value > ulong.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree));
                        return ulong.MaxValue;
                    }
                }
                return (ulong)value;
            }
            else
            {
                decimal value = 0;
                foreach (var c in text)
                {
                    value = value * 10 + (ulong)decValue(c);
                    if (value > ulong.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree));
                        return ulong.MaxValue;
                    }
                }
                return (ulong)value;
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

            return new Primitive.ConstString(type, tree.Text);
        }
    }
}
