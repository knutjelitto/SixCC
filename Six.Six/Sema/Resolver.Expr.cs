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
                var retry = false;
                foreach (var diagnostic in diagnostics.Diagnostics)
                {
                    Module.Add(diagnostic);

                    if (diagnostic is SemanticError semantic)
                    {
                        retry = retry || semantic.Message.EndsWith("XXX");
                    }
                }

                if (retry)
                {
                    throw new InvalidProgramException("RETRY");
                }
            }
            catch (Exception)
            {
                Didnt(expressionNode, expressionNode.GetType().Name);
            }
        }

        private Expression ResolveExpressionIntern(Container container, A.Expression expressionNode)
        {
            var resolved = resolve(container, expressionNode);
            this[expressionNode].Expr = resolved;
            this[expressionNode].Type = resolved.Type;

            return resolved;


            Expression resolve(Container container, A.Expression expressionNode)
            {

                switch (expressionNode)
                {
                    case A.Reference node:
                        return Reference(node);
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


            Expression Reference(A.Reference node)
            {
                return ResolveReference(container, node);
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
                
                var exprType = primary.Type.Resolved;

                if (exprType is Expression.Callable callable)
                {
                    Assert(args.Length == callable.Arguments.Length);
                    return new Expression.Call(Assoc.From(this, node), callable.Type, callable, args);
                }

                Assert(exprType is Type.Classy);
                if (exprType is Type.Classy classy)
                {
                    if (classy.Node() is A.Decl.Class)
                    {
                        var assoc = this[classy.Node()];
                        Assert(assoc.Scope is WhiteMemberScope);
                        if (assoc.Scope is WhiteMemberScope white)
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
                    }
                    else if (classy.Node() is A.Decl.Primitive)
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
                    var scope = classy.Scope();
                    Assert(scope is WhiteMemberScope);
                    if (scope is WhiteMemberScope white)
                    {
                        var member = ResolveMember(white, node.Reference);
                        return new Expression.Select(Assoc.From(this, node), expr, member);
                    }
                }

                throw Diagnostic(node, "not implemented");
            }

            Expression Prefix(A.Expression.Prefix node)
            {
                var primary = ResolveExpressionIntern(container, node.Expr);
                var type = primary.Type.Resolved;

                if (type is Type.Classy classy)
                {
                    var scope = classy.Scope();
                    Assert(scope is WhiteMemberScope);
                    if (scope is WhiteMemberScope white)
                    {
                        var member = ResolveMember(white, node.Op, node.Op.Name.Text + "_");
                        Assert(member is Expression.Callable);
                        if (member is Expression.Callable callable)
                        {
                            Assert(callable.Node() is A.Decl.Prefix);
                            return new Expression.Call(Assoc.From(this, node), callable.Type, callable);
                        }
                    }
                }

                throw Diagnostic(node, "not implemented");
            }

            Expression Infix(A.Expression.Infix node)
            {
                var left = ResolveExpressionIntern(container, node.Left);
                var right = ResolveExpressionIntern(container, node.Right);
                if (left != null && right != null)
                {
                    if (this[node.Left].ResolvedType() is Type.Classy classy)
                    {
                        var assoc = this[classy.Assoc.Node];
                        Assert(assoc.Scope is WhiteMemberScope);
                        if (assoc.Scope is WhiteMemberScope white)
                        {
                            var name = "_" + node.Op.Name.Text + "_";
                            if (white.Members.Find(name) is A.Decl.Infix infix)
                            {
                                var result = this[infix.Type].Type;
                                Assert(result != null);
                                if (result != null)
                                {
                                    var rightType = this[node.Right].ResolvedType();
                                    var rhsType = this[infix.Parameters[0]].ResolvedType();
                                    if (rightType != null && rhsType != null && ReferenceEquals(rightType, rhsType))
                                    {
                                        return new Expression.Infix(Assoc.From(this, node), result, left, right);
                                    }
                                }
                            }
                        }
                    }
                }
                ResolveOp(node, "infix");

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
