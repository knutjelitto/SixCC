using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static Decl ClassyFind(this Decl.Classy classy, A.Reference reference)
        {
            return classy.Block.Content.Find(reference, reference.Name.Text);
        }

        public static Decl ClassyFind(this Expr.ClassyReference node, A.Reference reference)
        {
            return node.ClassyDecl.ClassyFind(reference);
        }

        public static ILocation GetLocation(this Decl node)
        {
            return node.ADecl.GetLocation();
        }

        public static ILocation GetLocation(this A.TreeNode node)
        {
            if (node is A.With.Name named)
            {
                return Location.From(named.Name.Tree);
            }
            else
            {

                return Location.From(node.Tree);
            }
        }

        public static string GetKind(this A.TreeNode node)
        {
            return node.GetType().Name;
        }

        public static string GetName(this A.TreeNode node)
        {
            if (node is A.With.Name named)
            {
                return named.Name.Text;
            }
            return "--no-name--";
        }

        public static bool IsShared(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Shared);
        }

        public static bool IsSealed(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Sealed);
        }

        public static bool IsNative(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Native);
        }

        public static bool IsStatic(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Static);
        }

        public static bool IsAbstract(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Abstract);
        }

        public static bool IsVirtual(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Virtual);
        }

        public static bool IsOverride(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Override);
        }

        public static bool IsPrefinal(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(Names.Attr.Prefinal);
        }

        private static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
