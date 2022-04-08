using Six.Core;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static T FindMember<T>(this Decl.Classy classy, ILocation location, string name)
            where T : Decl
        {
            var found = classy.Block.Content.TryFind(name);

            if (found is T foundAsT)
            {
                return foundAsT;
            }
            if (classy.Extends != null)
            {
                return classy.Extends.FindMember<T>(location, name);
            }

            throw classy.Module.Errors.CantResolveMember(location, name);
        }

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
