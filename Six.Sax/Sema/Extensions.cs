using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public static class Extensions
    {
        public static Location GetLocation(this A.With.Name named)
        {
            return Location.From(named.Name.Tree);
        }

        public static string GetLocation(this Declaration declaration)
        {
            if (declaration.Ast is A.With.Name named)
            {
                return Location.From(named.Name.Tree).ToString();
            }
            return "--no-location--";
        }

        public static string GetKind(this Declaration declaration)
        {
            return declaration.Ast.GetType().Name;
        }

        public static string GetKind(this Statement statement)
        {
            return statement.Ast.GetType().Name;
        }

        public static string GetName(this Declaration declaration)
        {
            if (declaration.Ast is A.With.Name named)
            {
                return named.Name.Text;
            }
            return "--no-name--";
        }

        public static IEnumerable<Declaration> GetDeclarations(this Container container)
        {
            return container.Entities.OfType<Declaration>();
        }

        public static IEnumerable<Statement> GetStatements(this Container container)
        {
            return container.Entities.OfType<Statement>();
        }

        public static bool IsShared(this Declaration dc)
        {
            return dc.Ast is A.With.Prelude withPrelude && withPrelude.IsWith("shared");
        }

        public static bool IsNative(this Declaration dc)
        {
            return dc.Ast is A.With.Prelude withPrelude && withPrelude.IsWith("native");
        }

        public static bool IsWith(this A.With.Prelude withPrelude, string attribute)
        {
            return withPrelude.Prelude.Attributes.Any(a => a.Name.Text == attribute);
        }
    }
}
