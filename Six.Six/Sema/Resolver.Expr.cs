using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {
        public Expression? ResolveExpression(Container container, A.Expression? expressionNode)
        {
            if (expressionNode == null)
            {
                return null;
            }

            switch (expressionNode)
            {
                case A.Expression.Call node:
                    {
                        var expr = ResolveExpression(container, node.Expr);
                        var args = ResolveMany(container, node.Arguments);
                        if (expr != null && args != null)
                        {
                            var type = TypeOf(expr.Ast);
                            return new Expression.Call(node, expr, args.ToArray());
                        }
                        return null;
                    }
                case A.Reference node:
                    {
                        return Reference(node);
                    }
                case A.Expression.Prefix node:
                    {
                        return Prefix(node);
                    }
                case A.Expression.Infix node:
                    {
                        return Infix(node);
                    }
                case A.Expression.Select node:
                    {
                        return Select(node);
                    }
                case A.Expression.NaturalNumber node:
                    {
                        var value = ConvertNatural(node.Text);
                        var type = NaturalType(node, value);
                        if (type != null)
                        {
                            return new Expression.NaturalLiteral(node, type, value);
                        }
                        return null;
                    }
                default:
                    Didnt(expressionNode, expressionNode.GetType().Name);
                    return null;
            }


            Expression? Reference(A.Reference node)
            {
                var reference = ResolveReference(container, node);

                if (reference != null)
                {
                    if (reference.Declarations.Count == 1)
                    {
                        var declaration = reference.Declarations[0];
                    }
                }

                return reference;
            }


            Expression? Select(A.Expression.Select node)
            {
                _ = ResolveExpression(container, node.Expr);

                Didnt(expressionNode, expressionNode.GetType().Name);
                return null;
            }

            Type? NaturalType(A.TreeNode node, ulong value)
            {
                Type? type = ResolveInCore(node, Module.UInt64);
                if (type != null && value <= long.MaxValue)
                {
                    type = type.UnionWith(ResolveInCore(node, Module.Int64));
                    if (type != null && value <= uint.MaxValue)
                    {
                        type = type.UnionWith(ResolveInCore(node, Module.UInt32));
                        if (type != null && value <= int.MaxValue)
                        {
                            type = type.UnionWith(ResolveInCore(node, Module.Int32));
                            if (type != null && value <= ushort.MaxValue)
                            {
                                type = type.UnionWith(ResolveInCore(node, Module.UInt16));
                                if (type != null && value <= (ulong)short.MaxValue)
                                {
                                    type = type.UnionWith(ResolveInCore(node, Module.Int16));
                                    if (type != null && value <= byte.MaxValue)
                                    {
                                        type = type.UnionWith(ResolveInCore(node, Module.UInt8));
                                        if (type != null && value <= (ulong)sbyte.MaxValue)
                                        {
                                            type = type.UnionWith(ResolveInCore(node, Module.Int8));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return type;
            }

            Expression? Prefix(A.Expression.Prefix node)
            {
                var declarations = ResolveOp(node, "prefix");
                var expr = ResolveExpression(container, node.Expr);
                if (declarations != null && expr != null)
                {
                    Assert(declarations.Count > 0);
                    return new Expression.Prefix(node, expr);
                }
                return null;
            }

            Expression? Infix(A.Expression.Infix node)
            {
                var declarations = ResolveOp(node, "infix");
                var left = ResolveExpression(container, node.Left);
                var right = ResolveExpression(container, node.Right);
                if (declarations != null && left != null && right != null)
                {
                    Assert(declarations.Count > 0);
                    return new Expression.Infix(node, left, right);
                }
                return null;
            }

            Declarations? ResolveOp(A.Expression.OpExpression node, string xfix)
            {
                var declarations = container.Resolve(node.Op);
                if (declarations.Count == 0)
                {
                    Didnt(node.Op, $"{xfix}-operator `{node.Op.Name.Text}´");
                    return null;
                }
                return declarations;
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
