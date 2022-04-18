using Six.Core;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        [DebuggerStepThrough]
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

        public static bool IsWith(this A.TreeNode node, string attribute)
        {
            return node is A.With.Prelude withPrelude && withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
