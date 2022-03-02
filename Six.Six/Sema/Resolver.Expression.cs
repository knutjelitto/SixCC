using Six.Six.Instructions;
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

        private Expr.Delayed Expression(Scope container, A.Expression.Call node)
        {
            var delayed = new Expr.Delayed();

            var function = ResolveExpression(container, node.Expr);
            var args = ResolveArguments(container, node.Arguments).ToList();

            ResolveLater(() =>            
            {
                if (function.Resolved != null && args.All(arg => arg.Resolved != null))
                {
                    if (function.Resolved is Expr.FunctionReference reference)
                    {
                        var prms = reference.Decl.Parameters;

                        Assert(prms.Count >= args.Count);
                        var arguments = new List<Expr.Concrete>();

                        var index = 0;
                        for (; index < Math.Min(prms.Count, args.Count); ++index)
                        {
                            var argType = ResolveType(args[index].Resolved);
                            var prmType = ResolveType(prms[index]);

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

            ResolveLater(() =>
            {
                if (left.Resolved != null && right.Resolved != null)
                {
                    left.Resolved.FinalType = ResolveType(left.Resolved.Type);
                    right.Resolved.FinalType = ResolveType(right.Resolved.Type);

                    if (left.Resolved.FinalType is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content &&
                        classy.ADecl is A.Decl.Primitive)
                    {
                        var infix = content.Block.Find(node.Op, InfixName(node));
                        var result = ResolveType(infix);
                        if (result is Type.Callable callable)
                        {
                            delayed.Resolved = new Expr.CallMember(callable, left, right);
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else if (left.Resolved.FinalType is Type.Builtin builtin)
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

            ResolveLater(() =>
            {
                if (right.Resolved != null)
                {
                    right.Resolved.FinalType = ResolveType(right.Resolved);

                    if (right.Resolved.FinalType is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content)
                    {
                        if (classy.ADecl is A.Decl.Primitive)
                        {
                            var prefix = content.Block.Find(node.Op, PrefixName(node));
                            var result = ResolveType(prefix);
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
                    else if (right.Resolved.FinalType is Type.Builtin builtin)
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
            var delayed = new Expr.Delayed();

            delayed.Resolved = NaturalConst(tree);

            return delayed;
        }

        private Expr.Delayed Expression(Scope container, A.Reference tree)
        {
            var delayed = new Expr.Delayed();

            ResolveLater(() =>
            {
                delayed.Resolved = WalkReference(container.Resolve(tree, tree.Name.Text));
            });

            return delayed;
        }

        private Expr.Concrete WalkReference(Decl decl)
        {
            switch (decl)
            {
                case Decl.Parameter node:
                    return new Expr.ParameterReference(node, ResolveType(node.Type) ?? throw new NullReferenceException());
                case Decl.Let node:
                    return new Expr.LocalReference(node, ResolveType(node.Type) ?? throw new NullReferenceException());
                case Decl.Function node:
                    return new Expr.FunctionReference(node, ResolveType(node.Result) ?? throw new NullReferenceException());
                default:
                    Assert(false);
                    break;
            }
            return new Expr.Reference(decl);
        }
    }
}
