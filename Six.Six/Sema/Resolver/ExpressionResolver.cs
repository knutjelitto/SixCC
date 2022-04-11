using System;
using Six.Six.Types;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class ExpressionResolver : ResolverCore
    {
        public ExpressionResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

        public LazyExpr ResolveExpression(Block block, A.Expression node)
        {
            return Expression((dynamic)block, (dynamic)node);
        }

        private LazyExpr Expression(Block block, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private LazyExpr Expression(Block block, A.Expression.If node)
        {
            return new LazyExpr(Module, () =>
            {
                var condition = ExpressionConditions(block, node.Conditions);
                var then = ResolveExpression(block, node.Then);
                var @else = ResolveExpression(block, node.Else);

                return new Expr.If(condition, then, @else);
            });
        }

        public LazyExpr ExpressionConditions(Block block, IEnumerable<A.Expression> nodes)
        {
            var conditions = nodes.ToList();
            Assert(conditions.Count >= 1);

            return new LazyExpr(Module, () =>
            {
                var first = ResolveExpression(block, conditions[0]);
                var type = Module.CoreFindType(Names.Core.Boolean);

                if (conditions.Count == 1)
                {
                    return first.Expr;
                }
                else
                {
                    Assert(conditions.Count > 1);
                    return new Expr.AndThen(type, first, ExpressionConditions(block, conditions.Skip(1)));
                }
            });

        }

        private LazyExpr Expression(Block block, A.Expression.Select node)
        {
            return new LazyExpr(Module, () =>
            {
                var primary = ResolveExpression(block, node.Expr).Expr;

                if (primary is Expr.AliasReference aliasRef)
                {
                    var resolved = T.ResolveType(aliasRef.Decl.Type);

                    if (resolved is Decl.Classy classy)
                    {
                        var found = classy.Block.Resolve(node.Reference);

                        Assert(found.IsStatic);

                        if (found is Decl.Attribute attribute)
                        {
                            return Expr.CallFunction.From(attribute);
                        }
                        else if (found is Decl.Function function)
                        {
                            return new Expr.FunctionReference(function);
                        }
                        else if (found is Decl.Field field)
                        {
                            return new Expr.FieldReference(field);
                        }
                    }
                    else
                    {
                        Assert(false);
                        throw new NotImplementedException();
                    }

                    Assert(Module.HasErrors);
                }
                else if (primary is Expr.ClassyReference classyReference)
                {
                    var classy = classyReference.ClassyDecl;

                    var found = classy.Block.Resolve(node.Reference);

                    Assert(found.IsStatic);

                    if (found is Decl.Attribute attribute)
                    {
                        return Expr.CallFunction.From(attribute);
                    }
                    else if (found is Decl.Function function)
                    {
                        return new Expr.FunctionReference(function);
                    }

                    Assert(false);
                }
                else if (primary is Expr.ConstructorReference constructorReference)
                {
                    var found = T.ResolveType(constructorReference.Decl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Block.Resolve(node.Reference);

                        return select(primary, classy, referenced);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else if (primary is Expr.ParameterReference parameterReference)
                {
                    var found = T.ResolveType(parameterReference.Decl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Block.Resolve(node.Reference);

                        return select(primary, classy, referenced);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else if (primary is Expr.LocalReference localReference)
                {
                    var found = T.ResolveType(localReference.Decl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Block.Resolve(node.Reference);

                        return select(primary, classy, referenced);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else if (primary is Expr.FieldReference fieldReference)
                {
                    var found = T.ResolveType(fieldReference.Decl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Block.Resolve(node.Reference);

                        return select(primary, classy, referenced);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else if (primary is Expr.CallConstructor callConstructor)
                {
                    var found = T.ResolveType(callConstructor.Class.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Block.Resolve(node.Reference);

                        return select(primary, classy, referenced);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else
                {
                    Assert(Module.HasErrors);
                }

                Assert(false);
                throw new NotImplementedException();

                static Expr select(Expr reference, Decl.Classy classy, Decl referenced)
                {
                    if (referenced is Decl.Attribute attribute)
                    {
                        return Expr.CallFunction.From(reference, attribute, new List<Expr>());
                    }
                    else if (referenced is Decl.Function function)
                    {
                        return new Expr.SelectFunction(reference, classy, function);
                    }
                    else if (referenced is Decl.Field field)
                    {
                        return new Expr.SelectField(reference, classy, field);
                    }
                    else
                    {
                        Assert(false);
                        throw new NotImplementedException();
                    }
                }
            });
        }

        private LazyExpr Expression(Block block, A.Expression.Call node)
        {
            return new LazyExpr(Module, () =>
            {
                var func = ResolveExpression(block, node.Expr);
                var args = ResolveArguments(block, node.Arguments).ToList();

                if (func.Expr is Expr.FunctionReference functionReference)
                {
                    var function = functionReference.FunctionDecl;

                    var prms = function.Parameters;
                    var arguments = function.IsClassMember ? MakeMemberArguments(prms, args) : MakeArguments(prms, args);

                    return Expr.CallFunction.From(functionReference.FunctionDecl, arguments);
                }
                else if (func.Expr is Expr.ClassReference classReference)
                {
                    var clazz = classReference.ClassDecl;

                    if (clazz.IsAbstract)
                    {
                        throw Errors.CanNotCreateInstanceOfAbstractClass(clazz, Names.Nouns.Class);
                    }

                    var defaultCtor = clazz.FindMember<Decl.Constructor>(node.Expr.GetLocation(), Module.DefaultCtor);

                    var prms = defaultCtor.Parameters;

                    if (defaultCtor.IsNative)
                    {
                        Assert(true);

                        var arguments = MakeArguments(prms, args);

                        return new Expr.CallNativeConstructor(clazz, defaultCtor, arguments);
                    }
                    else
                    {
                        var arguments = MakeMemberArguments(prms, args);

                        return new Expr.CallConstructor(clazz, defaultCtor, arguments);
                    }

                }
                else if (func.Expr is Expr.LocalReference local)
                {
                    Assert(local.Decl.Type is Type.Callable);

                    return ResolveIndirect(local, local.Decl.Type as Type.Callable);
                }
                else if (func.Expr is Expr.ParameterReference parameter)
                {
                    Assert(parameter.Decl.Type is Type.Callable);

                    return ResolveIndirect(parameter, parameter.ParameterDecl.Type as Type.Callable);
                }
                else if (func.Expr is Expr.SelectFunction selectFunction)
                {
                    var function = selectFunction.Function;

                    if (selectFunction.Function.IsStatic)
                    {
                        Assert(false);
                    }
                    else
                    {
                        var prms = function.Parameters;
                        var arguments = function.IsClassMember ? MakeMemberArguments(prms, args) : MakeArguments(prms, args);
                        return new Expr.CallMember(
                            selectFunction.Classy,
                            function,
                            selectFunction.Reference,
                            arguments);
                    }
                }
                else
                {
                    Assert(Module.HasErrors);
                }

                Assert(false);
                throw new NotImplementedException();

                List<Expr> MakeMemberArguments(IReadOnlyList<Decl.Local> prms, List<LazyExpr> args)
                {
                    Assert(prms.Count > args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < args.Count; ++index)
                    {
                        var prmType = T.LowerType(prms[index + 1].Type);
                        var argType = T.LowerType(args[index].Expr.Type);

                        Assert(Checker.CanAssign(prmType, argType));

                        arguments.Add(args[index].Expr);
                    }
                    for (; ++index < prms.Count;)
                    {
                        if (prms[index] is Decl.Parameter param)
                        {
                            Assert(param.Default != null);

                            arguments.Add(param.Default!);
                        }
                        else
                        {
                            Assert(prms[index] is Decl.Parameter);
                        }
                    }

                    Assert(arguments.Count == prms.Count - 1);

                    return arguments;
                }

                List<Expr> MakeArguments(IReadOnlyList<Decl.Local> prms, List<LazyExpr> args)
                {
                    Assert(prms.Count >= args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < Math.Min(prms.Count, args.Count); ++index)
                    {
                        var argType = T.ResolveType(args[index].Expr.Type);
                        var prmType = T.ResolveType(prms[index].Type);

                        Assert(Checker.CanAssign(prmType, argType));

                        arguments.Add(args[index].Expr);
                    }
                    for (; index < prms.Count; ++index)
                    {
                        if (prms[index] is Decl.Parameter param)
                        {
                            Assert(param.Default != null);

                            arguments.Add(param.Default!);
                        }
                        else
                        {
                            Assert(prms[index] is Decl.Parameter);
                        }
                    }

                    Assert(arguments.Count == prms.Count);

                    return arguments;
                }

                Expr ResolveIndirect(Expr value, Type.Callable? callable)
                {
                    Assert(callable != null);
                    var prms = callable.Parameters;

                    Assert(prms.Count >= args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < Math.Min(prms.Count, args.Count); ++index)
                    {
                        var argType = T.ResolveType(args[index].Expr.Type);
                        var prmType = T.ResolveType(prms[index]);

                        Assert(Checker.CanAssign(prmType, argType));

                        arguments.Add(args[index].Expr!);
                    }
                    for (; index < prms.Count; ++index)
                    {
                        Assert(false);
                    }

                    Assert(arguments.Count == prms.Count);

                    return new Expr.CallIndirect(value, callable, arguments);
                }
            });
        }

        private IEnumerable<LazyExpr> ResolveArguments(Block block, A.Arguments arguments)
        {
            foreach (var argument in arguments)
            {
                yield return ResolveExpression(block, argument);
            }
        }

        private LazyExpr Expression(Block block, A.Expression.Infix node)
        {
            return new LazyExpr(Module, () =>
            {
                var left = ResolveExpression(block, node.Left);
                var right = ResolveExpression(block, node.Right);

                if (left.Expr.Type is Decl.Classy classy)
                {
                    var infix = classy.Block.Resolve(node.Op, node.InfixName());

                    if (infix is Decl.Function function)
                    {
                        return new Expr.CallInfixMember(classy, function, left.Expr, right.Expr);
                    }

                    Assert(false);
                }
                else if (left.Expr.Type is Type.Builtin builtin)
                {
                    return builtin.Infix(node.Op, left.Expr, right.Expr);
                }
                else if (left.Expr.Type is Type.Callable callable)
                {
                    Assert(false);

                    if (callable.Result is Decl.Classy classy2)
                    {
                        var infix = classy2.Block.Resolve(node.Op, node.InfixName());

                        if (infix is Decl.Function function)
                        {
                            return new Expr.CallInfixMember(classy2, function, left.Expr, right.Expr);
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
            return new LazyExpr(Module, () =>
            {
                var right = ResolveExpression(block, node.Expr);

                if (right.Expr.Type is Decl.Classy classy)
                {
                    var prefix = classy.Block.Resolve(node.Op, node.PrefixName());

                    if (prefix is Decl.Function function)
                    {
                        return new Expr.CallPrefixMember(classy, function, right.Expr);
                    }

                    Assert(false);
                }
                else if (right.Expr.Type is Type.Builtin builtin)
                {
                    return builtin.Prefix(node.Op, right.Expr);
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
            return new LazyExpr(Module, () => NaturalConst(tree));
        }

        private LazyExpr Expression(Block block, A.Expression.String.Plain tree)
        {
            return new LazyExpr(Module, () => PlainString(tree));
        }

        private LazyExpr Expression(Block block, A.Reference tree)
        {
            return new LazyExpr(Module, () =>
            {
                var resolved = block.Resolve(tree.GetLocation(), tree.Name.Text);

                switch (resolved)
                {
                    case Decl.Parameter decl:
                        return new Expr.ParameterReference(decl);
                    case Decl.SelfParameter decl:
                        return new Expr.ParameterReference(decl);
                    case Decl.LetVar decl:
                        return new Expr.LocalReference(decl);
                    case Decl.Global decl:
                        return new Expr.GlobalReference(decl);
                    case Decl.Function decl:
                        return new Expr.FunctionReference(decl);
                    case Decl.Constructor decl:
                        return new Expr.ConstructorReference(decl);
                    case Decl.Class decl:
                        return new Expr.ClassReference(decl);
                    case Decl.Object decl:
                        return new Expr.ObjectReference(decl);
                    case Decl.Alias decl:
                        return new Expr.AliasReference(decl);
                    case Decl.Field decl:
                        return new Expr.FieldReference(decl);
                    case Decl.Attribute decl:
                        return Expr.CallFunction.From(decl);
                    default:
                        Assert(false);
                        throw new NotImplementedException();
                }
            });
        }
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
