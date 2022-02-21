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

        public void DumpEntity(A.TreeNode node)
        {
            Walk(node);
        }

        private void Walk(A.TreeNode node)
        {
            wl(Name(node));

            indent(() =>
            {
                Dump((dynamic)node);
            });
        }

        private string Name(A.TreeNode node)
        {
            var prefix = "";
            if (node is A.Stmt)
            {
                prefix = "Stmt:";
            }
            else if (node is A.Decl)
            {
                prefix = "Decl:";
            }
            var name = node is A.With.Name named ? $" {named.Name.Text}" : "";
            return $"{prefix}{node.GetType().Name}{name}";
        }

        private void Dump(Assoc assoc)
        {
            if (assoc.Type != null)
            {
                wl($"{assoc.Type}");
            }
            if (assoc.Expr != null)
            {
                wl($"{assoc.Expr}");
            }
        }

        private void Dump(A.Decl.Let node)
        {
            Dump(Resolver[node.Value]);
            if (node.Type != null)
            {
                Dump(Resolver[node.Type]);
            }
        }

        private void Dump(A.TreeNode node)
        {
            var assoc = Resolver[node];

            if (assoc.ResolvedType() is Type.Classy classy && classy.Assoc.Node is A.With.Name named)
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
