namespace Six.Gen
{
    internal static class CsWriter
    {
        public static string CsString(this string text)
        {
            return $"\"{string.Join(string.Empty, text.Select(chr => Escape(chr)))}\"";

            //TODO: incomplete
            static string Escape(char chr)
            {
                switch (chr)
                {
                    case '"':
                        return "\\\"";
                    case '\\':
                        return "\\\\";
                    case '\0':
                        return "\\0";
                    case '\a':
                        return "\\a";
                    case '\b':
                        return "\\b";
                    case '\f':
                        return "\\f";
                    case '\n':
                        return "\\n";
                    case '\r':
                        return "\\r";
                    case '\t':
                        return "\\t";
                    case '\v':
                        return "\\v";
                    default:
                        return chr.ToString();
                }
            }
        }

        public static string CsIndentifier(this string identifier)
        {
            if (identifier.StartsWith("%"))
            {
                return "__" + Cap(identifier.Substring(1));
            }

            var parts = identifier.Split('-');

            return "_" + string.Join(string.Empty, parts.Take(1).Concat(parts.Skip(1).Select(part => Cap(part))));
        }

        public static string Cap(string name)
        {
            var first = char.ToUpperInvariant(name.First()).ToString();
            var rest = string.Join(string.Empty, name.Skip(1).Select(chr => char.ToLowerInvariant(chr)));

            return first + rest;
        }
    }
}
