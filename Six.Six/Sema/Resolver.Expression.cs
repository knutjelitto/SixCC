using Six.Core;
using Six.Six.Builtins;
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
        private string InfixName(A.Name node)
        {
            return $"infix({node.Text})";
        }
        private string InfixName(A.Decl.Infix node)
        {
            return InfixName(node.Name);
        }
        private string InfixName(A.Expression.OpExpression node)
        {
            return InfixName(node.Op.Name);
        }
        private string PrefixName(A.Name node)
        {
            return $"prefix({node.Text})";
        }
        private string PrefixName(A.Expression.OpExpression node)
        {
            return PrefixName(node.Op.Name);
        }

        private string PrefixName(A.Decl.Prefix node)
        {
            return PrefixName(node.Name);
        }

        private bool Assignable = false;

        private IDisposable Assignability(bool assignable)
        {
            var saved = assignable;
            this.Assignable = assignable;
            return new Disposable(() => this.Assignable = saved);
        }

        public LazyExpr ResolveExpression(Scope scope, A.Expression node, bool assignable = false)
        {
            using (Assignability(assignable))
            {
                return Expression(scope, (dynamic)node);
            }
        }

        private LazyExpr Expression(Scope container, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private LazyExpr Expression(Scope container, A.Expression.If node)
        {
            return new LazyExpr(Module, () =>
            {
                var condition = ExpressionConditions(container, node.Conditions);
                var then = ResolveExpression(container, node.Then);
                var @else = ResolveExpression(container, node.Else);

                return new Expression.If(condition, then, @else);
            });
        }

        private LazyExpr ExpressionConditions(Scope container, IEnumerable<A.Expression> nodes)
        {
            var conditions = nodes.ToList();
            Assert(conditions.Count >= 1);

            return new LazyExpr(Module, () =>
            {
                var first = ResolveExpression(container, conditions[0]);

                if (conditions.Count == 1)
                {
                    return first.Expr;
                }
                else
                {
                    Assert(conditions.Count > 1);
                    return new Expression.AndThen(first, ExpressionConditions(container, conditions.Skip(1)));
                }
            });

        }

        private LazyExpr Expression(Scope container, A.Expression.Select node)
        {
            var assign = Assignable;

            return new LazyExpr(Module, () =>
            {
                var primary = ResolveExpression(container, node.Expr);

                if (primary.Expr is Expression.ClassyReference classyRef)
                {
                    var found = classyRef.ClassyFind(node.Reference);

                    if (found is Decl.Attribute attribute)
                    {
                        Assert(attribute.IsStatic());
                        return new Expression.SelectAttribute(classyRef, attribute, assign);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else if (primary.Expr is Expression.ConstructorReference constructorReference)
                {
                    var found = ResolveType(constructorReference.ConstructorDecl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.Scope.Block.Resolve(node.Reference, node.Reference.Name.Text);

                        Assert(false);
                    }
                    else
                    {
                        Assert(Module.HasErrors);
                    }
                }
                else if (primary.Expr is Expression.ParameterReference parameterReference)
                {
                    var found = ResolveType(parameterReference.ParameterDecl.Type);

                    if (found is Type.Declared declared && declared.Decl is Decl.Classy classy)
                    {
                        var referenced = classy.ClassyFind(node.Reference);

                        if (referenced is Decl.Attribute attribute)
                        {
                            return new Expression.SelectAttribute(parameterReference, attribute, assign);
                        }
                        else if (referenced is Decl.Field field)
                        {
                            return new Expression.SelectField(parameterReference, field, assign);
                        }
                        else
                        {
                            Assert(false);
                        }
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
            });
        }

        private LazyExpr Expression(Scope container, A.Expression.Call node)
        {
            return new LazyExpr(Module, () =>
            {
                var func = ResolveExpression(container, node.Expr);
                var args = ResolveArguments(container, node.Arguments).ToList();

                if (func.Expr is Expression.FunctionReference function)
                {
                    var callable = function.FunctionDecl.Type as Type.Callable;
                    Assert(callable != null);
                    var prms = function.FunctionDecl.Parameters;

                    Assert(prms.Count >= args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < Math.Min(prms.Count, args.Count); ++index)
                    {
                        var argType = ResolveType(args[index].Expr.Type);
                        var prmType = ResolveType(prms[index].Type);    

                        Assert(ReferenceEquals(argType, prmType));

                        arguments.Add(args[index].Expr!);
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

                    return new Expression.CallFunction(function, arguments);
                }
                else if (func.Expr is Expression.ClassReference klassReference)
                {
                    var klass = klassReference.ClassDecl;
                    var defaultCtor = klass.ClassyScope().Block.Find(klass.ADecl, Module.DefaultCtor) as Decl.Constructor;
                    Assert(defaultCtor != null);
                    var callable = defaultCtor.Type as Type.Callable;
                    Assert(callable != null);
                    var prms = defaultCtor.Parameters;

                    Assert(prms.Count > args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < args.Count; ++index)
                    {
                        var argType = LowerType(args[index].Expr.Type);
                        var prmType = LowerType(prms[index+1].Type);

                        Assert(ReferenceEquals(argType, prmType));

                        arguments.Add(args[index].Expr);
                    }
                    for (; ++index < prms.Count; )
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

                    return new Expression.CallConstructor(klass, defaultCtor, arguments);

                }
                else if (func.Expr is Expression.LocalReference local)
                {
                    return ResolveIndirect(local, local.LocalDecl.Type as Type.Callable);
                }
                else if (func.Expr is Expression.ParameterReference parameter)
                {
                    return ResolveIndirect(parameter, parameter.ParameterDecl.Type as Type.Callable);
                }
                else
                {
                    Assert(Module.HasErrors);
                }

                Assert(false);
                throw new NotImplementedException();

                Expr ResolveIndirect(Expr value, Type.Callable? callable)
                {
                    Assert(callable != null);
                    var prms = callable.Parameters;

                    Assert(prms.Count >= args.Count);
                    var arguments = new List<Expr>();

                    var index = 0;
                    for (; index < Math.Min(prms.Count, args.Count); ++index)
                    {
                        var argType = ResolveType(args[index].Expr.Type);
                        var prmType = ResolveType(prms[index]);

                        Assert(ReferenceEquals(argType, prmType));

                        arguments.Add(args[index].Expr!);
                    }
                    for (; index < prms.Count; ++index)
                    {
                        Assert(false);
                    }

                    Assert(arguments.Count == prms.Count);

                   return new Expression.CallIndirect(value, callable, arguments);
                }
            });
        }

        private IEnumerable<LazyExpr> ResolveArguments(Scope container, A.Arguments arguments)
        {
            foreach (var argument in arguments)
            {
                yield return ResolveExpression(container, argument);
            }
        }

        private LazyExpr Expression(Scope container, A.Expression.Infix node)
        {
            return new LazyExpr(Module, () =>
            {
                var left = ResolveExpression(container, node.Left);
                var right = ResolveExpression(container, node.Right);

                if (left.Expr.Type is Type.Reference reference &&
                    reference.Decl is Decl.Classy classy)
                {
                    var infix = classy.Scope.Block.Find(node.Op, InfixName(node));
                 
                    if (infix.IsNative())
                    {
                        return Builtins.Resolve(classy).Infix(node.Op, left.Expr, right.Expr);
                    }

                    var result = ResolveDeclType(infix);
                    if (result is Type.Callable callable)
                    {
                        return new Expression.CallMember(callable, left, right);
                    }
                    else
                    {
                        Assert(false);
                    }
                    Assert(false);
                }
                else if (left.Expr.Type is Type.Builtin builtin)
                {
                    return builtin.Infix(node.Op, left.Expr, right.Expr);
                }
                else
                {
                    Assert(Module.HasErrors);
                }

                Assert(false);
                throw new NotImplementedException();
            });
        }


        private LazyExpr Expression(Scope container, A.Expression.Prefix node)
        {
            return new LazyExpr(Module, () =>
            {
                var right = ResolveExpression(container, node.Expr);

                if (right.Expr.Type is Type.Reference reference &&
                    reference.Decl is Decl.Classy classy &&
                    classy.Container is ContentScope content)
                {
                    if (classy.ADecl is A.Decl.Classy)
                    {
                        var prefix = content.Block.Find(node.Op, PrefixName(node));

                        if (prefix.IsNative())
                        {
                            return Builtins.Resolve(classy).Prefix(node.Op, right.Expr);
                        }

                        var result = ResolveDeclType(prefix);
                        if (result is Type.Callable callable)
                        {
                            return new Expression.CallMember(callable, right);
                        }
                        else
                        {
                            Assert(false);
                        }

                        Assert(false);
                    }
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

        private LazyExpr Expression(Scope container, A.Expression.NaturalNumber tree)
        {
            return new LazyExpr(Module, () => NaturalConst(tree));
        }

        private LazyExpr Expression(Scope container, A.Expression.String.Plain tree)
        {
            return new LazyExpr(Module, () => PlainString(tree));
        }

        private LazyExpr Expression(Scope container, A.Reference tree)
        {
            return new LazyExpr(Module, () =>
            {
                var decl = container.Resolve(tree, tree.Name.Text);

                Expression.Reference reference;

                switch (decl)
                {
                    case Decl.Parameter node:
                        reference = new Expression.ParameterReference(node);
                        break;
                    case Decl.SelfParameter node:
                        reference = new Expression.ParameterReference(node);
                        break;
                    case Decl.LetVar node:
                        reference = new Expression.LocalReference(node);
                        break;
                    case Decl.Attribute node:
                        reference = new Expression.AttributeReference(node);
                        break;
                    case Decl.Function node:
                        reference = new Expression.FunctionReference(node);
                        break;
                    case Decl.Constructor node:
                        reference = new Expression.ConstructorReference(node);
                        break;
                    case Decl.Class node:
                        reference = new Expression.ClassReference(node);
                        break;
                    default:
                        Assert(false);
                        throw new NotImplementedException();
                }

                return reference;
            });
        }
    }
}
