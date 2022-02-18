using Six.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class SemaDumper
    {
        public Writer Writer { get; }

        public SemaDumper(Writer writer)
        {
            Writer = writer;
        }

        public void DumpEntity(A.TreeNode node)
        {
            DumpTree(node);
        }

        private void DumpTree(A.TreeNode tree)
        {
            Dump((dynamic)tree);
        }

        private void Dump(A.TreeNode tree)
        {
            Assert(true);
        }

        private void Dump(A.Stmt.Expr tree)
        {
            Writer.WriteLine($"Expr.Statement");
            Assert(true);
        }

        private static string? Attrs(Entity declaration)
        {
            var list = new List<string?>
            {
                declaration.IsShared ? "shared" : null,
                declaration.IsNative ? "native" : null
            };
            var attrs = string.Join(", ", list.Where(s => s is not null));
            if (attrs.Length > 0)
            {
                return $"[{attrs}]";
            }
            return null;
        }
    }
}
