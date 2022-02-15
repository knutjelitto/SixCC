using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class Extensions
    {
        public static Location GetLocation(this Entity entity)
        {
            if (entity.Ast is A.With.Name named)
            {
                return Location.From(named.Name.Tree);
            }
            else
            {

                return Location.From(entity.Ast.Tree);
            }
        }

        public static string GetKindOne(this Entity entity)
        {
            return entity.GetKind().Substring(0, 1);
        }

        public static string GetKind(this Entity entity)
        {
            return entity.Ast.GetType().Name;
        }

        public static string GetName(this Entity entity)
        {
            if (entity.Ast is A.With.Name named)
            {
                return named.Name.Text;
            }
            return "--no-name--";
        }

        public static IEnumerable<Declaration> GetDeclarations(this Container container)
        {
            return container.Children.OfType<Declaration>();
        }

        public static IEnumerable<Statement> GetStatements(this Container container)
        {
            return container.Children.OfType<Statement>();
        }

        public static bool IsShared(this Entity entity)
        {
            return entity.Ast is A.With.Prelude withPrelude && withPrelude.IsWith("shared");
        }

        public static bool IsNative(this Entity entity)
        {
            return entity.Ast is A.With.Prelude withPrelude && withPrelude.IsWith("native");
        }

        public static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
