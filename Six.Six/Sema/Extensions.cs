using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static ClassyScope ClassyScope(this Decl node)
        {
            return node.Container as ClassyScope ?? throw new InvalidCastException();
        }

        public static Decl ClassyFind(this Decl node, A.Reference reference)
        {
            return node.ClassyScope().Block.Find(reference, reference.Name.Text);
        }
        public static FuncyScope FuncyScope(this Decl node)
        {
            return node.Container as FuncyScope ?? throw new InvalidCastException();
        }

        public static string FullName(this Decl node)
        {
            return $"{node.Container.Parent.FullName}::{node.Name}";
        }

        public static string FullName(this Decl.Function node)
        {
            return $"{node.Container.FullName}";
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

        public static string GetKindOne(this A.TreeNode node)
        {
            return node.GetKind().Substring(0, 1);
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
            return node is A.With.Prelude withPrelude && withPrelude.IsWith("shared");
        }

        public static bool IsNative(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith("native");
        }

        public static bool IsStatic(this A.TreeNode node)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith("static");
        }

        public static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
