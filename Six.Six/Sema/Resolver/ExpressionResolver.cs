using System;

using Six.Six.Types;

using static Six.Six.Sema.Expr;

using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class ExpressionResolver : ResolverCore
    {
        private readonly ExpressionSelect Select;
        private readonly ExpressionCall Call;

        public ExpressionResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
            Select = new ExpressionSelect();
            Call = new ExpressionCall(resolver);
        }

        public LazyExpr ResolveExpression(Block block, A.Expression node)
        {
            return Expression((dynamic)block, (dynamic)node);
        }

        public LazyExpr ExpressionConditions(Block block, IEnumerable<A.Expression> nodes)
        {
            var conditions = nodes.ToList();
            Assert(conditions.Count >= 1);

            return new LazyExpr(() =>
            {
                var first = ResolveExpression(block, conditions[0]);
                var type = Module.FindCoreClass(Names.Core.Boolean);

                if (conditions.Count == 1)
                {
                    return first.Value;
                }
                else
                {
                    Assert(conditions.Count > 1);
                    return new AndThen(type, first, ExpressionConditions(block, conditions.Skip(1)));
                }
            });
        }

        private LazyExpr Expression(Block block, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private LazyExpr Expression(Block block, A.Expression.If node)
        {
            return new LazyExpr(() =>
            {
                var condition = ExpressionConditions(block, node.Conditions);
                var then = ResolveExpression(block, node.Then);
                var @else = ResolveExpression(block, node.Else);

                return new If(condition, then, @else);
            });
        }

        private LazyExpr Expression(Block block, A.Expression.Select node)
        {
            return new LazyExpr(() =>
            {
                var primary = ResolveExpression(block, node.Expr).Value;

                return Select.SelectOnAny(primary, node.Reference);
            });
        }

        private LazyExpr Expression(Block block, A.Expression.Call node)
        {
            return new LazyExpr(() =>
            {
                var primary = ResolveExpression(block, node.Expr).Value;
                var args = GetArguments(block, node.Arguments).ToList();

                return Call.On(primary, args);
            });
        }

        private IEnumerable<Expr> GetArguments(Block block, A.Arguments arguments)
        {
            foreach (var argument in arguments)
            {
                yield return ResolveExpression(block, argument).Value;
            }
        }

        private LazyExpr Expression(Block block, A.Expression.Infix node)
        {
            return new LazyExpr(() =>
            {
                var left = ResolveExpression(block, node.Left).Value;
                var right = ResolveExpression(block, node.Right).Value;

                var leftType = left.Type;

                if (leftType is Decl.Classy classy)
                {
                    var infix = classy.Block.Resolve(node.Op, node.InfixName());

                    if (infix is Decl.Function function)
                    {
                        return new CallInfixMember(classy, function, left, right);
                    }

                    Assert(false);
                }
                else if (leftType is Type.Callable callable)
                {
                    Assert(false);

                    if (callable.Result is Decl.Classy classy2)
                    {
                        var infix = classy2.Block.Resolve(node.Op, node.InfixName());

                        if (infix is Decl.Function function)
                        {
                            return new CallInfixMember(classy2, function, left, right);
                        }

                    }
                }
                else
                {
                    Assert(Module.HasErrors);
                }

                Assert(false);
                throw new NotImplementedException();
            });
        }


        private LazyExpr Expression(Block block, A.Expression.Prefix node)
        {
            return new LazyExpr(() =>
            {
                var right = ResolveExpression(block, node.Expr);

                if (right.Value.Type is Decl.Classy classy)
                {
                    var prefix = classy.Block.Resolve(node.Op, node.PrefixName());

                    if (prefix is Decl.Function function)
                    {
                        return new CallPrefixMember(classy, function, right.Value);
                    }

                    Assert(false);
                }
                else if (right.Value.Type is Type.Builtin builtin)
                {
                    return builtin.Prefix(node.Op, right.Value);
                }
                else
                {
                    Assert(false);
                }

                Assert(false);
                throw new NotImplementedException();
            });
        }

        private LazyExpr Expression(Block block, A.Expression.NaturalNumber tree)
        {
            return new LazyExpr(() => NaturalConst(tree));
        }

        private LazyExpr Expression(Block block, A.Expression.String.Plain tree)
        {
            return new LazyExpr(() => PlainString(tree));
        }

        private LazyExpr Expression(Block block, A.Reference tree)
        {
            return new LazyExpr(() =>
            {
                var resolved = block.Resolve(tree);

                if (resolved is Type type)
                {
                    Assert(true);
                }

                switch (resolved)
                {
                    case Decl.Parameter decl:
                        return new ParameterReference(decl);
                    case Decl.SelfParameter decl:
                        return new ParameterReference(decl);
                    case Decl.LetVar decl:
                        return new LocalReference(decl);
                    case Decl.Global decl:
                        return new GlobalReference(decl);
                    case Decl.Function decl:
                        return new FunctionReference(decl);
                    case Decl.Constructor decl:
                        return new ConstructorReference(decl);
                    case Decl.Class decl:
                        return new ClassReference(decl);
                    case Decl.Object decl:
                        return new ObjectReference(decl);
                    case Decl.Alias decl:
                        return new AliasReference(decl);
                    case Decl.Field decl:
                        return new FieldReference(decl);
                    case Decl.Attribute decl:
                        return CallFunction.From(decl);
                    default:
                        Assert(false);
                        throw new NotImplementedException();
                }
            });
        }

        private Expr NaturalConst(A.Expression.NaturalNumber tree)
        {
            var text = ExtractSuffix(tree, out var suffix);

            var value = ConvertNatural(tree, text);

            switch (suffix)
            {
                case "s32":
                    if (value > int.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstS32(Module.FindCoreClass(Names.Core.S32), int.MaxValue);
                    }
                    return new Primitive.ConstS32(Module.FindCoreClass(Names.Core.S32), (int)value);
                case "s64":
                    if (value > long.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstS64(Module.FindCoreClass(Names.Core.S64), long.MaxValue);
                    }
                    return new Primitive.ConstS64(Module.FindCoreClass(Names.Core.S64), (long)value);
                case "u32":
                    if (value > uint.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstU32(Module.FindCoreClass(Names.Core.U32), uint.MaxValue);
                    }
                    return new Primitive.ConstU32(Module.FindCoreClass(Names.Core.U32), (uint)value);
                case "u64":
                    if (value > ulong.MaxValue)
                    {
                        Module.Add(Errors.TooBigInteger(tree, $"{suffix}"));
                        return new Primitive.ConstU64(Module.FindCoreClass(Names.Core.U64), ulong.MaxValue);
                    }
                    return new Primitive.ConstU64(Module.FindCoreClass(Names.Core.U64), value);
                case "":
                    Assert(value <= ulong.MaxValue);

#if false
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
                    var type = new Type.Intersection(Module);
                    type.AddRange(types);
                    return new Expr.ConstNatural(type, value);
#else

                    if (value > long.MaxValue)
                    {
                        return new Primitive.ConstU64(Module.FindCoreClass(Names.Core.U64), value);
                    }
                    else if (value > int.MaxValue)
                    {
                        if (value > uint.MaxValue)
                        {
                            return new Primitive.ConstS64(Module.FindCoreClass(Names.Core.S64), (long)value);
                        }
                        return new Primitive.ConstU32(Module.FindCoreClass(Names.Core.U32), (uint)value);
                    }
                    else
                    {
                        return new Primitive.ConstS32(Module.FindCoreClass(Names.Core.S32), (int)value);
                    }
#endif
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }

        }

        private ulong ConvertNatural(A.Expression.NaturalNumber tree, string text)
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

        private Expr PlainString(A.Expression.String.Plain tree)
        {
            var type = Module.FindCoreClass(Names.Core.String);

            return new Primitive.ConstString(type, tree.Text);
        }
    }
}
