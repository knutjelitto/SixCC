namespace SixTools.Helpers
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
            switch (c)
            {
                case '&': return "&amp;";
                case '<': return "&lt;";
                case '>': return "&gt;";

                case '\x00': return Control("NUL");
                case '\x01': return Control("SOH");
                case '\x02': return Control("STX");
                case '\x03': return Control("ETX");
                case '\x04': return Control("EOT");
                case '\x05': return Control("ENQ");
                case '\x06': return Control("ACK");
                case '\x07': return Control("BEL");
                case '\x08': return Control("BS");
                case '\x09': return Control("HT");
                case '\x0A': return Control("LF");
                case '\x0B': return Control("VT");
                case '\x0C': return Control("FF");
                case '\x0D': return Control("CR");
                case '\x0E': return Control("SO");
                case '\x0F': return Control("SI");

                case '\x10': return Control("DLE");
                case '\x11': return Control("DC1");
                case '\x12': return Control("DC2");
                case '\x13': return Control("DC3");
                case '\x14': return Control("DC4");
                case '\x15': return Control("NAK");
                case '\x16': return Control("SYN");
                case '\x17': return Control("ETB");
                case '\x18': return Control("CAN");
                case '\x19': return Control("EOM");
                case '\x1A': return Control("SUB");
                case '\x1B': return Control("ESC");
                case '\x1C': return Control("FS");
                case '\x1D': return Control("GS");
                case '\x1E': return Control("RS");
                case '\x1F': return Control("US");

                case '\x20': return Printable("&UnderBracket;");

                case '\x7F': return Control("DEL");

                case '\x80': return Control("PAD");
                case '\x81': return Control("HOP");
                case '\x82': return Control("BPH");
                case '\x83': return Control("NBH");
                case '\x84': return Control("IND");
                case '\x85': return Control("NEL");
                case '\x86': return Control("SSA");
                case '\x87': return Control("ESA");
                case '\x88': return Control("HTS");
                case '\x89': return Control("HTJ");
                case '\x8A': return Control("VTS");
                case '\x8B': return Control("PLD");
                case '\x8C': return Control("PLU");
                case '\x8D': return Control("RI");
                case '\x8E': return Control("SS2");
                case '\x8F': return Control("SS3");

                case '\x90': return Control("DCS");
                case '\x91': return Control("PU1");
                case '\x92': return Control("PU2");
                case '\x93': return Control("STS");
                case '\x94': return Control("CCH");
                case '\x95': return Control("MW");
                case '\x96': return Control("SPA");
                case '\x97': return Control("EPA");
                case '\x98': return Control("SOS");
                case '\x99': return Control("SGC");
                case '\x9A': return Control("SCI");
                case '\x9B': return Control("CSI");
                case '\x9C': return Control("ST");
                case '\x9D': return Control("OSC");
                case '\x9E': return Control("PM");
                case '\x9F': return Control("APC");

                case '\xA0': return Control("NBSP");

                default:

                    return Printable($"{c}");
            }

            static string Control(string ctl)
            {
                return $"<span class='char-control'>{ctl}<span role='explanation'>TODO:&nbsp;explain&nbsp;control&nbsp;{ctl}</span></span>";
            }

            static string Printable(string print)
            {
                return $"<span class='char-printable'>{print}<span role='explanation'>TODO:&nbsp;explain&nbsp;character&nbsp;'{print}'</span></span>";
            }
        }
    }
}
