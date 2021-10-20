namespace SixTools.Formats
{
    public static class Esc
    {
        public static string Full(string literal)
        {
            return string.Join(string.Empty, literal.Select(c => Full(c)));

        }

        public static string Full(char c)
        {
            switch (c)
            {
                case '\a':
                    return "\\a";
                case '\b':
                    return "\\b";
                case '\x1B':
                    return "\\e";
                case '\f':
                    return "\\f";
                case '\t':
                    return "\\t";
                case '\v':
                    return "\\v";
                case '\r':
                    return "\\r";
                case '\n':
                    return "\\n";
                case '\"':
                    return "\\\"";
                case '\'':
                    return "\\\'";
                default:
                    if (c < ' ')
                    {
                        return $"\\x{(int)c:X2}";
                    }
                    else if (char.IsAscii(c))
                    {
                        return c.ToString();
                    }
                    return $"\\u{(int)c:X4}";
            }
        }

        public static string Html(string literal)
        {
            return string.Join(string.Empty, literal.Select(c => Html(c)));
        }

        public static string Html(char c)
        {
            string name;

            switch (c)
            {
                case '&': return "&amp;";
                case '<': return "&lt;";
                case '>': return "&gt;";

                case '\a': name = "BEL"; break;
                case '\b': name = "BS"; break;
                case '\f': name = "FF"; break;
                case '\n': name = "LF"; break;
                case '\r': name = "CR"; break;
                case '\t': name = "TAB"; break;
                case '\v': name = "VT"; break;
                case ' ': name= "&#x2420"; break;

                default:
                    if (c is < (char)32 or (char)127 or (>= (char)128 and < (char)160))
                    {
                        return $"&#x3008;<tspan class='hex'>{(int)c:2X}</tspan>&#x3009;";
                    }

                    return $"{c}";
            }

            return $"&#x3008;<tspan class='esc'>{name}</tspan>&#x3009;";
        }
    }
}
