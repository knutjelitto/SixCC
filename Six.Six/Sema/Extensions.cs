using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static Decl FindMember(this Decl.Classy classy, A.Reference reference, string? name = null)
        {
            return classy.FindMember(reference.GetLocation(), name ?? reference.Name.Text);
        }

        public static Decl FindMember(this Decl.Classy classy, ILocation location, string name)
        {
            var found = classy.Block.Content.TryFind(name);

            if (found != null)
            {
                return found;
            }
            if (classy.Extends != null)
            {
                return classy.Extends.FindMember(location, name);
            }

            throw classy.Module.Errors.CantResolveMember(location, name);
        }

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

        public static string GetKind(this Decl decl)
        {
            return decl.GetType().Name;
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

        public static bool IsWith(this A.TreeNode node, string attribute)
        {
            return node is A.With.Prelude withPrelude && withPrelude.IsWith(attribute);
        }

        private static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
