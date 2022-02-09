using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public static class Extensions
    {
        public static Location GetLocation(this INamed named)
        {
            return Location.From(named.Name.Tree);
        }

        public static string GetKind(this Node node)
        {
            return node.GetType().Name;
        }

        public static bool IsShared(this Node node)
        {
            return node is IPreluded preluded && preluded.Prelude.Attributes.Any(a => a.Name.Text == "shared");
        }

        public static bool IsNative(this Node node)
        {
            return node is IPreluded preluded && preluded.Prelude.Attributes.Any(a => a.Name.Text == "native");
        }
    }
}
