﻿namespace Six.Core
{
    public static class Escaper
    {
        public static string Esc(this Codepoint cp)
        {
            var utf32 = (int)cp;

            if (utf32 < ' ')
            {
                switch (utf32)
                {
                    case '\n': return "\\n";
                    case '\r': return "\\r";
                    case '\t': return "\\t";
                }
                return $"\\x{utf32:X02}";
            }
            else if (utf32 == '\'')
            {
                return "\\'";
            }
            else if (utf32 == '\"')
            {
                return "\\\"";
            }
            else if (utf32 == '\\')
            {
                return "\\\\";
            }
            else if (utf32 > 0x1FFF && utf32 <= 0xFFFF)
            {
                return $"\\u{utf32:X04}";
            }
            else if (utf32 > 0xFFFF)
            {
                return $"\\u{utf32:X06}";
            }
            else
            {
                return char.ConvertFromUtf32(utf32);
            }
        }

        public static string Esc(this CpString cps)
        {
            return $"'{string.Join(string.Empty, cps.Select(cp => cp.Esc()))}'";
        }

        public static string Esc(this string text)
        {
            return $"'{text.InnerEsc()}'";
        }

        public static string InnerEsc(this string text)
        {
            return $"{string.Join(string.Empty, text.Codepoints().Select(cp => cp.Esc()))}";
        }

        public static string ShortEsc(this string text, int length)
        {
            if (text.Length > length)
            {
                return text.Substring(0, length).Esc() + "…";
            }
            return (text.Esc());
        }
    }
}
