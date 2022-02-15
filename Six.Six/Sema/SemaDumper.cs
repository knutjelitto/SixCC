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

        public void DumpEntity(Entity entity)
        {
            Dump((dynamic)entity);
            using (Writer.Indent())
            {
                DumpTree(entity.Ast);
            }
        }

        private void DumpTree(A.TreeNode tree)
        {
            Dump((dynamic)tree);
        }

        private void Dump(A.TreeNode tree)
        {
            Assert(true);
        }

        private void Dump(A.Statement.Expr tree)
        {
            Writer.WriteLine($"Expr.Statement");
            Assert(true);
        }


        private void DumpInner(Entity entity)
        {
            using (Writer.Indent())
            {
                DumpAttrs(entity);
                foreach (var child in entity.Container.Children)
                {
                    DumpEntity(child);
                }
            }
        }

        private void Dump(Declaration declaration)
        {
            Writer.WriteLine($"{declaration.GetKind()} {declaration.GetName()}");

            DumpInner(declaration);
        }

        private void Dump(Statement statement)
        {
            Writer.WriteLine($"{nameof(Statement)} {statement.GetKind()}");
        }

        private void Dump(Statement.Block block)
        {
            Writer.WriteLine($"{nameof(Statement.Block)}");

            Writer.WriteLine("{");
            DumpInner(block);
            Writer.WriteLine("}");
        }

        private void Dump(Entity entity)
        {
            Assert(false);
        }

        private void DumpAttrs(Entity entity)
        {
            var attrs = Attrs(entity);
            if (attrs != null)
            {
                Writer.WriteLine(attrs);
            }
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
