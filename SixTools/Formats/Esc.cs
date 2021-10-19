namespace SixTools.Formats
{
    public static class Esc
    {
        public static string Full(string literal)
        {
            return string.Join(string.Empty, literal.Select(c => esc(c)));

            static string esc(char c)
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
        }
    }
}
