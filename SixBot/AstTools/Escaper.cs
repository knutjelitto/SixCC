namespace SixBot.Ast
{
    internal static class Escaper
    {
        public static string Esc(this Codepoint cp)
        {
            var utf32 = (int)cp;

            if (utf32 < ' ')
            {
                return $"\\x{utf32:X02}";
            }
            else if (utf32 == '\'')
            {
                return "\\'";
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
    }
}
