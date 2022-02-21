using Six.Core.Errors;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {
        public void ResolveExpression(Container container, A.Expression? expressionNode)
        {
            if (expressionNode == null)
            {
                return;
            }

            try
            {
                ResolveExpressionIntern(container, expressionNode);
            }
            catch (DiagnosticException diagnostics)
            {
                foreach (var diagnostic in diagnostics.Diagnostics)
                {
                    Module.Add(diagnostic);
                }
            }
            catch (InvalidProgramException)
            {
                throw;
            }
            catch (Exception)
            {
                Didnt(expressionNode, expressionNode.GetType().Name);
            }
        }

        private Expression ResolveExpressionIntern(Container container, A.Expression expressionNode)
        {
            var resolved = resolve(expressionNode);
            this[expressionNode].Expr = resolved;
            this[expressionNode].Type = resolved.Type;

            return resolved;


            Expression resolve(A.Expression expressionNode)
            {

                switch (expressionNode)
                {
                    case A.Reference node:
                        return ResolveReference(container, node);
                    case A.Expression.Call node:
                        return Call(node);
                    case A.Expression.Prefix node:
                        return Prefix(node);
                    case A.Expression.Infix node:
                        return Infix(node);
                    case A.Expression.Select node:
                        return Select(node);
                    case A.Expression.NaturalNumber node:
                        return Natural(node);
                    default:
                        throw new NotImplementedException($"resolving `{expressionNode.GetType().Name}´");
                }
            }


            Expression Natural(A.Expression.NaturalNumber node)
            {
                var value = ConvertNatural(node.Text);
                var type = NaturalType(node, value);

                return new Expression.NaturalLiteral(Assoc.From(this, node), type, value);

                Type NaturalType(A.TreeNode node, ulong value)
                {
                    if (value > long.MaxValue)
                    {
                        return ResolveInCore(node, Module.Core.UInt64);
                    }
                    else if (value > int.MaxValue)
                    {
                        return ResolveInCore(node, Module.Core.Int64);
                    }
                    else
                    {
                        return ResolveInCore(node, Module.Core.Int32);
                    }
                }
            }

            Expression Call(A.Expression.Call node)
            {
                var primary = ResolveExpressionIntern(container, node.Expr);
                var args = ResolveMany(container, node.Arguments);

                if (primary is Expression.Callable callable)
                {
                    Assert(args.Length == callable.Arguments.Length);
                    return new Expression.Call(Assoc.From(this, node), callable.Type, callable, args);
                }

                var exprType = primary.Type.Resolved;

                if (exprType is Expression.Callable callable2)
                {
                    Assert(args.Length == callable2.Arguments.Length);
                    return new Expression.Call(Assoc.From(this, node), callable2.Type, callable2, args);
                }

                Assert(exprType is Type.Classy);
                if (exprType is Type.Classy classy)
                {
                    var white = classy.WhiteScope() ?? throw WhiteScopeExpected(primary.Node());

                    if (classy.Node() is A.Decl.Class)
                    {
                        // default constructor
                        var dctor = white.Members.Find(Module.DefaultCtor);
                        Assert(dctor != null);
                        if (dctor != null)
                        {
                            var type = this[classy.Assoc.Node].Type;
                            Assert(type != null);
                            return new Expression.CallCtor(Assoc.From(this, node), type, primary, args);
                        }
                    }
                    else if (classy.Node() is A.Decl.Primitive)
                    {
                        Assert(false);
                    }
                    else
                    {
                        Assert(false);
                    }
                }

                Assert(false);
                throw new NotImplementedException();
            }

            Expression Select(A.Expression.Select node)
            {
                var expr = ResolveExpressionIntern(container, node.Expr);
                var exprType = expr.Type.Resolved;

                Assert(exprType is Type.Classy);
                if (exprType is Type.Classy classy)
                {
                    var white = classy.WhiteScope() ?? throw WhiteScopeExpected(node);
                 
                    var member = ResolveMember(white, node.Reference);
                    return new Expression.Select(Assoc.From(this, node), expr, member);
                }

                throw Diagnostic(node, "not implemented");
            }

            Expression Prefix(A.Expression.Prefix node)
            {
                var expr = ResolveExpressionIntern(container, node.Expr);

                if (expr.Type.Resolved is Type.Classy classy)
                {
                    var white = classy.WhiteScope() ?? throw WhiteScopeExpected(node);

                    var member = ResolvePrefix(white, node.Op);
                    if (member is Expression.Callable callable)
                    {
                        return new Expression.Call(Assoc.From(this, node), callable.Type, callable);
                    }
                }


                ResolveOp(node, "prefix");
                Assert(false);
                throw new NotImplementedException();
            }

            Expression Infix(A.Expression.Infix node)
            {
                var left = ResolveExpressionIntern(container, node.Left);
                var right = ResolveExpressionIntern(container, node.Right);

                if (left.Type.Resolved is Type.Classy classy)
                {
                    var white = classy.WhiteScope() ?? throw WhiteScopeExpected(node);

                    var member = ResolveInfix(white, node.Op);
                    if (member is Expression.Callable callable)
                    {
                        return new Expression.Call(Assoc.From(this, node), callable.Type, callable, right);
                    }
                }

                ResolveOp(node, "infix");
                Assert(false);
                throw new NotImplementedException();
            }

            A.Decl? ResolveOp(A.Expression.OpExpression node, string xfix)
            {
                var decl = container.Resolve(node.Op);
                if (decl == null)
                {
                    Didnt(node.Op, $"unresolved {xfix}-operator `{node.Op.Name.Text}´");
                    return null;
                }
                return decl;
            }
        }

        private ulong ConvertNatural(string text)
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
