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
        private string InfixName(A.Name name)
        {
            return "_" + name.Text + "_";
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
            return node.Text + "_";
        }
        private string PrefixName(A.Expression.OpExpression node)
        {
            return PrefixName(node.Op.Name);
        }
        private string PrefixName(A.Decl.Prefix node)
        {
            return PrefixName(node.Name);
        }

        private Expr.Delayed ResolveExpression(Scope scope, A.Expression node)
        {
            return Expression(scope, (dynamic)node);
        }

        private Expr.Delayed Expression(Scope container, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr.Delayed Expression(Scope container, A.Expression.Select node)
        {
            var delayed = new Expr.Delayed();
            var primary = ResolveExpression(container, node.Expr);

            ScheduleType(() =>
            {
                if (primary.Resolved != null)
                {
                    if (primary.Resolved is Expr.ClassyReference classyRef)
                    {
                        var found = classyRef.Decl.ClassyFind(node.Reference);

                        if (found is Decl.Attribute attribute)
                        {
                            Assert(attribute.IsStatic());
                            Assert(attribute.Type != null);
                            delayed.Resolved = new Expr.SelectAttribute(classyRef, attribute, attribute.Type);
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }
            });

            return delayed;
        }

        private Expr.Delayed Expression(Scope container, A.Expression.Call node)
        {
            var delayed = new Expr.Delayed();

            var function = ResolveExpression(container, node.Expr);
            var args = ResolveArguments(container, node.Arguments).ToList();

            ScheduleExpr(() =>            
            {
                if (function.Resolved != null && args.All(arg => arg.Resolved != null))
                {
                    if (function.Resolved is Expr.FunctionReference reference)
                    {
                        var callable = reference.FunctionDecl.Type as Type.Callable;
                        Assert(callable != null);
                        var prms = reference.FunctionDecl.Parameters;

                        Assert(prms.Count >= args.Count);
                        var arguments = new List<Expr.Concrete>();

                        var index = 0;
                        for (; index < Math.Min(prms.Count, args.Count); ++index)
                        {
                            var argType = ResolveExprType(args[index].Resolved);
                            var prmType = ResolveDeclType(prms[index]);

                            Assert(ReferenceEquals(argType, prmType));

                            arguments.Add(args[index].Resolved!);
                        }
                        for (; index < prms.Count; ++index)
                        {
                            Assert(prms[index].Default != null);

                            arguments.Add(prms[index].Default!);
                        }

                        Assert(arguments.Count == prms.Count);

                        delayed.Resolved = new Expr.CallFunction(reference, arguments);
                    }
                    else if (function.Resolved is Expr.LocalReference local)
                    {
                        var callable = local.LocalDecl.Type as Type.Callable;
                        Assert(callable != null);
                        var prms = callable.Parameters;

                        Assert(prms.Count >= args.Count);
                        var arguments = new List<Expr.Concrete>();

                        var index = 0;
                        for (; index < Math.Min(prms.Count, args.Count); ++index)
                        {
                            var argType = ResolveExprType(args[index].Resolved);
                            var prmType = ResolveType(prms[index]);

                            Assert(ReferenceEquals(argType, prmType));

                            arguments.Add(args[index].Resolved!);
                        }
                        for (; index < prms.Count; ++index)
                        {
                            Assert(false);

                        Assert(arguments.Count == prms.Count);

                        delayed.Resolved = new Expr.CallFunction(reference, arguments);

                        Assert(false);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }

            });

            return delayed;
        }

        private IEnumerable<Expr.Delayed> ResolveArguments(Scope container, A.Arguments arguments)
        {
            foreach (var argument in arguments)
            {
                yield return ResolveExpression(container, argument);
            }
        }

        private Expr.Delayed Expression(Scope container, A.Expression.Infix node)
        {
            var delayed = new Expr.Delayed();

            var left = ResolveExpression(container, node.Left);
            var right = ResolveExpression(container, node.Right);

            ScheduleExpr(() =>
            {
                if (left.Resolved != null && right.Resolved != null)
                {
                    left.Resolved.Type = ResolveType(left.Resolved.NominalType);
                    right.Resolved.Type = ResolveType(right.Resolved.NominalType);

                    if (left.Resolved.Type is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content &&
                        classy.ADecl is A.Decl.Primitive)
                    {
                        var infix = content.Block.Find(node.Op, InfixName(node));
                        var result = ResolveDeclType(infix);
                        if (result is Type.Callable callable)
                        {
                            delayed.Resolved = new Expr.CallMember(callable, left, right);
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else if (left.Resolved.Type is Type.Builtin builtin)
                    {
                        delayed.Resolved = builtin.Infix(node.Op, left, right);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }

            });

            return delayed;
        }


        private Expr.Delayed Expression(Scope container, A.Expression.Prefix node)
        {
            var delayed = new Expr.Delayed();

            var right = ResolveExpression(container, node.Expr);

            ScheduleExpr(() =>
            {
                if (right.Resolved != null)
                {
                    right.Resolved.Type = ResolveExprType(right.Resolved);

                    if (right.Resolved.Type is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content)
                    {
                        if (classy.ADecl is A.Decl.Primitive)
                        {
                            var prefix = content.Block.Find(node.Op, PrefixName(node));
                            var result = ResolveDeclType(prefix);
                            if (result is Type.Callable callable)
                            {
                                delayed.Resolved = new Expr.CallMember(callable, right);
                            }
                            else
                            {
                                Assert(false);
                            }
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else if (right.Resolved.Type is Type.Builtin builtin)
                    {
                        delayed.Resolved = builtin.Prefix(node.Op, right);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }

            });

            return delayed;
        }

        private Expr.Delayed Expression(Scope container, A.Expression.NaturalNumber tree)
        {
            return new Expr.Delayed() { Resolved = NaturalConst(tree) };
        }

        private Expr.Delayed Expression(Scope container, A.Reference tree)
        {
            var delayed = new Expr.Delayed();

            ScheduleExpr(() =>
            {
                var decl = container.Resolve(tree, tree.Name.Text);

                Expr.Reference reference;

                switch (decl)
                {
                    case Decl.Parameter node:
                        reference = new Expr.ParameterReference(node);
                        Assert(node.Type != null);
                        break;
                    case Decl.Let node:
                        reference = new Expr.LocalReference(node);
                        Assert(node.Type != null);
                        break;
                    case Decl.Var node:
                        reference = new Expr.LocalReference(node);
                        Assert(node.Type != null);
                        break;
                    case Decl.Attribute node:
                        reference = new Expr.AttributeReference(node);
                        Assert(node.Type != null);
                        break;
                    case Decl.Function node:
                        reference = new Expr.FunctionReference(node);
                        Assert(node.Type != null);
                        break;
                    case Decl.Primitive node:
                        reference = new Expr.PrimitiveReference(node);
                        Assert(node.Type != null);
                        break;
                    default:
                        Assert(false);
                        throw new NotImplementedException();
                }


                delayed.Resolved = reference;
            });

            return delayed;
        }
    }
}
