using Six.Core;
using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class SemaDumper : WithWriter
    {
        public SemaDumper(Writer writer, Resolver resolver)
            : base(writer)
        {
            Resolver = resolver;
        }

        public Resolver Resolver { get; }

        public void DumpEntity(A.Decl node)
        {
            Walk(node);
        }

        private void Walk(A.TreeNode? node)
        {
            if (node != null)
            {
                wl(Name(node));

                indent(() =>
                {
                    var assoc = Resolver[node];
                    Dump((dynamic)node);

                    if (assoc.Expr is Expression expr)
                    {
                        Assert(true);

                        wl($"-----{expr.GetType().FullName!.Substring(13)}");
                        Dump((dynamic)expr);
                    }
                });
            }
        }

        void Dump(Expression expr)
        {

        }

        private string Name(A.TreeNode node)
        {
            var prefix = "";
            if (node is A.Stmt)
            {
                prefix = "Stmt::";
            }
            else if (node is A.Decl)
            {
                prefix = "Decl::";
            }
            else if (node is A.Expression)
            {
                prefix = "Expr::";
            }
            else
            {
                Assert(false);
            }
            var name = node is A.With.Name named ? $" {named.Name.Text}" : "";
            return $"{prefix}{node.GetType().Name}{name}";
        }

        private void Dump(A.Decl.Let node)
        {
            Walk(node.Type);
            Walk(node.Value);
        }

        private void Dump(A.Decl.Var node)
        {
            Walk(node.Type);
            Walk(node.Value);
        }

        private void Dump(A.Expression.Prefix node)
        {
            Walk(node.Op);
            Walk(node.Expr);
        }

        private void Dump(A.Expression.Infix node)
        {
            var assoc = Resolver[node];

            Walk(node.Op);
            Walk(node.Left);
            Walk(node.Right);
        }

        private void Dump(A.Expression.Select node)
        {
            Walk(node.Expr);
            Walk(node.Reference);
        }

        private void Dump(A.Stmt.Return node)
        {
            Walk(node.Expression);
        }

        private void Dump(A.Stmt.Assign node)
        {
            Walk(node.Left);
            Walk(node.Right);
        }

        private void Dump(A.Reference reference)
        {
            var assoc = Resolver[reference];
            var type = Resolver[reference].Type;
            var expr = assoc.Expr;
            Assert(expr == null || expr is Expression);
        }

        private void Dump(A.TreeNode node)
        {
            var assoc = Resolver[node];

            if (assoc.ResolvedType() is Type.Classy classy && classy.Node() is A.With.Name named)
            {
                wl($"type: {named.Name.Text}");
            }

            if (assoc.Scope != null)
            {
                if (assoc.Scope.Children.Count > 0)
                {
                    wl("children:");
                    indent(() =>
                    {
                        foreach (var child in assoc.Scope.Children)
                        {
                            Walk(child);
                        }
                    });
                }

                if (assoc.Scope is MemberScope members)
                {
                    wl("members:");
                    indent(() =>
                    {
                        foreach (var child in members.Members.Children)
                        {
                            Walk(child);
                        }
                    });
                }
            }
        }
    }
}
