#pragma warning disable IDE0066 // Convert switch statement to expression

using Six.Core;

namespace SixTools.Helpers
{
    public static class Esc
    {
        public static string Full(string text)
        {
            return string.Join(string.Empty, text.Codepoints().Select(cp => Full(cp)));

        }

        public static string Full(Codepoint cp)
        {
            switch ((int)cp)
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
                    if ((int)cp < ' ')
                    {
                        return $"\\x{(int)cp:X2}";
                    }
                    else if ((int)cp < 128)
                    {
                        return cp.ToString();
                    }
                    return $"\\u{{{(int)cp:X4}}}";
            }
        }

        public static IEnumerable<string> SvgStrings(string text)
        {
            return text.Codepoints().Select(cp => SvgString(cp));
        }

        public static string SvgSequence(this string text)
        {
            return string.Join(string.Empty, SvgStrings(text));
        }

        public static string SvgString(Codepoint cp)
        {
            return ControlName(cp) ?? cp.ToString();

        }

        public static string? ControlName(Codepoint cp)
        {
            switch ((int)cp)
            {
                case '\x00': return "NUL";
                case '\x01': return "SOH";
                case '\x02': return "STX";
                case '\x03': return "ETX";
                case '\x04': return "EOT";
                case '\x05': return "ENQ";
                case '\x06': return "ACK";
                case '\x07': return "BEL";
                case '\x08': return "BS";
                case '\x09': return "TAB";
                case '\x0A': return "LF";
                case '\x0B': return "VT";
                case '\x0C': return "FF";
                case '\x0D': return "CR";
                case '\x0E': return "SO";
                case '\x0F': return "SI";

                case '\x10': return "DLE";
                case '\x11': return "DC1";
                case '\x12': return "DC2";
                case '\x13': return "DC3";
                case '\x14': return "DC4";
                case '\x15': return "NAK";
                case '\x16': return "SYN";
                case '\x17': return "ETB";
                case '\x18': return "CAN";
                case '\x19': return "EOM";
                case '\x1A': return "SUB";
                case '\x1B': return "ESC";
                case '\x1C': return "FS";
                case '\x1D': return "GS";
                case '\x1E': return "RS";
                case '\x1F': return "US";

                case '\x20': return "⎵";

                case '\x7F': return "DEL";

                case '\x80': return "PAD";
                case '\x81': return "HOP";
                case '\x82': return "BPH";
                case '\x83': return "NBH";
                case '\x84': return "IND";
                case '\x85': return "NEL";
                case '\x86': return "SSA";
                case '\x87': return "ESA";
                case '\x88': return "HTS";
                case '\x89': return "HTJ";
                case '\x8A': return "VTS";
                case '\x8B': return "PLD";
                case '\x8C': return "PLU";
                case '\x8D': return "RI";
                case '\x8E': return "SS2";
                case '\x8F': return "SS3";

                case '\x90': return "DCS";
                case '\x91': return "PU1";
                case '\x92': return "PU2";
                case '\x93': return "STS";
                case '\x94': return "CCH";
                case '\x95': return "MW";
                case '\x96': return "SPA";
                case '\x97': return "EPA";
                case '\x98': return "SOS";
                case '\x99': return "SGC";
                case '\x9A': return "SCI";
                case '\x9B': return "CSI";
                case '\x9C': return "ST";
                case '\x9D': return "OSC";
                case '\x9E': return "PM";
                case '\x9F': return "APC";

                case '\xA0': return "NBSP";

                case '\u2028': return "LS";
                case '\u2029': return "PS";

                default:
                    return null;
            }
        }

        public static bool IsPrint(this string str, int offset)
        {
            return char.IsLetterOrDigit(str, offset)
                || char.IsNumber(str, offset)
                || char.IsPunctuation(str, offset)
                || char.IsSymbol(str, offset)
                ;
        }

        public static string HtmlEntity(Codepoint cp)
        {
            switch ((int)cp)
            {
                case '&': return "&amp;";
                case '<': return "&lt;";
                case '>': return "&gt;";
                default: return cp.ToString();
            }
        }

        public static string HtmlEntity(string text)
        {
            return string.Join(string.Empty, text.Codepoints().Select(cp => HtmlEntity(cp)));
        }

        public static string Html(string text)
        {
            return string.Join(string.Empty, text.Codepoints().Select(cp => Html(cp)));
        }

        public static string Html(Codepoint cp)
        {
            switch ((int)cp)
            {
                case '&': return "&amp;";
                case '<': return "&lt;";
                case '>': return "&gt;";

                default:
                    var h = ControlName(cp);
                    if (h != null)
                    {
                        return Control(h);
                    }
                    return Printable(cp.ToString());

            }

            static string Control(string ctl)
            {
                return $"<span class='char-control'>{ctl}</span>";
            }

            static string Printable(string print)
            {
                return $"<span class='char-printable'>{print}</span>";
            }
        }
    }
}
