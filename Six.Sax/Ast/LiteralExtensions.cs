using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public static class LiteralExtensions
    {
        public static string StartText(this RToken token)
        {
            Assert(token.Text.StartsWith("\"") && token.Text.EndsWith("``"));

            return Decode(token.Text[1..^2]);
        }

        public static string MidText(this RToken token)
        {
            Assert(token.Text.StartsWith("``") && token.Text.EndsWith("``"));

            return Decode(token.Text[2..^2]);
        }

        public static string EndText(this RToken token)
        {
            Assert(token.Text.StartsWith("``") && token.Text.EndsWith("\""));

            return Decode(token.Text[2..^1]);
        }

        public static string PlainText(this RToken token)
        {
            Assert(token.Text.StartsWith("\"") && token.Text.EndsWith("\""));

            return Decode(token.Text[1..^1]);
        }

        public static string VerbatimText(this RToken token)
        {
            var text = token.Text;

            Assert(text.StartsWith("\"\"\"") && text.EndsWith("\"\"\""));

            return text[3..^3];
        }

        private static string Decode(string text)
        {
            var builder = new StringBuilder();
            var offset = 0;

            while (offset < text.Length)
            {
                switch (text[offset])
                {
                    case '\\':
                        offset++;
                        switch (text[offset])
                        {
                            case 'a':
                                builder.Append('\a');
                                offset++;
                                break;
                            case 'b':
                                builder.Append('\b');
                                offset++;
                                break;
                            case 'e':
                                builder.Append('\x1B');
                                offset++;
                                break;
                            case 'f':
                                builder.Append('\f');
                                offset++;
                                break;
                            case 'n':
                                builder.Append('\n');
                                offset++;
                                break;
                            case 'r':
                                builder.Append('\r');
                                offset++;
                                break;
                            case 't':
                                builder.Append('\t');
                                offset++;
                                break;
                            case 'v':
                                builder.Append('\v');
                                offset++;
                                break;
                            case '\'':
                                builder.Append('\'');
                                offset++;
                                break;
                            case '\\':
                                builder.Append('\\');
                                offset++;
                                break;
                            case '\"':
                                builder.Append('\"');
                                offset++;
                                break;
                            case '`':
                                builder.Append('`');
                                offset++;
                                break;
                            case '0':
                                builder.Append('\0');
                                offset++;
                                break;
                            case '{':
                                offset++;
                                if (text[offset] == '#')
                                {
                                    offset++;
                                    var codepoint = 0;
                                    while (offset < text.Length && IsHexDigit(text[offset]))
                                    {
                                        codepoint = codepoint * 16 + GetHexValue(text[offset]);
                                        offset++;
                                    }
                                    Assert(offset < text.Length && text[offset] == '}');
                                    builder.Append(char.ConvertFromUtf32(codepoint));
                                    offset++;
                                }
                                else
                                {
                                    while (offset < text.Length && IsCharacterName(text[offset]))
                                    {
                                        offset++;
                                    }
                                    Assert(text[offset] == '}');
                                    offset++;
                                }
                                break;
                            default:
                                throw new System.InvalidOperationException();
                        }
                        break;
                    default:
                        builder.Append(text[offset]);
                        offset++;
                        break;
                }
            }

            return builder.ToString();
        }

        private static bool IsHexDigit(char chr)
        {
            return
                '0' <= chr && chr <= '9' ||
                'a' <= chr && chr <= 'f' ||
                'A' <= chr && chr <= 'F';
        }

        private static int GetHexValue(char chr)
        {
            if ('0' <= chr && chr <= '9')
                return chr - '0';
            if ('a' <= chr && chr <= 'f')
                return chr - 'a' + 10;
            if ('A' <= chr && chr <= 'F')
                return chr - 'A' + 10;
            throw new System.InvalidOperationException();
        }

        private static bool IsCharacterName(char chr)
        {
            return
                char.IsLetterOrDigit(chr) ||
                chr == '_' ||
                chr == '-' ||
                chr == ' ' ||
                chr == '(' ||
                chr == ')';
        }

    }
}
