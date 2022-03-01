using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static string FullName(this Decl node)
        {
            return $"{node.Container.Parent.FullName}::{node.Name}";
        }

        public static Location GetLocation(this Decl node)
        {
            return node.ADecl.GetLocation();
        }

        public static Location GetLocation(this A.TreeNode node)
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

        public static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
