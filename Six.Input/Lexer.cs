using Six.Core;
using Six.Core.Errors;
using System.Globalization;


namespace Six.Input
{
    internal class Lexer
    {
        private const string eofInLiteral = "premature eof in string literal";
        private const string illegalInLiteral = "illegal character '{0}' in string literal";
        private const string shortLiteral = "empty string literal";
        private const string incompleteEscape = "incomplete escape sequence";
        private const string illegalCharacter = "illegal character '{0}'";
        private const string illegalUnicodeEscape = "illegal unicode escape";

        public Lexer(Source source)
        {
            Source = source;
            start = 0;
            offset = 0;
        }

        public Source Source { get; }

        private int start = 0;
        private int offset = 0;

        private int Current => Source[offset];
        private int Next => Source[offset + 1];

        public Token GetNext()
        {
            SkipWhitespace();
            if (More)
            {
                switch(Current)
                {
                    case '(':
                        return Token(TKind.LeftParent);
                    case ')':
                        return Token(TKind.RightParent);
                    case '{':
                        return Token(TKind.LeftCurly);
                    case '}':
                        return Token(TKind.RightCurly);
                    case '[':
                        return Token(TKind.LeftBracket);
                    case ']':
                        return Token(TKind.RightBracket);
                    case '<':
                        return Token(TKind.LeftAngle);
                    case '>':
                        return Token(TKind.RightAngle);
                    case ':':
                        return Token(TKind.Colon);
                    case ';':
                        return Token(TKind.Semi);
                    case ',':
                        return Token(TKind.Comma);
                    case '|':
                        return Token(TKind.Alter);
                    case '^':
                    case '¬':
                        return Token(TKind.Not);
                    case '?':
                        return Token(TKind.Option);
                    case '*':
                        return Token(TKind.Star);
                    case '+':
                        return Token(TKind.Plus);
                    case '-':
                        return Token(TKind.Minus);
                    case '.' when OneMore && Next == '.':
                        return Token(TKind.Range, 2);
                    case '.':
                        return Token(TKind.Any);
                    case '\'':
                        return Literal();
                    case '%':
                        return Special();
                    default:
                        if (Letter(Current))
                        {
                            return Identifier();
                        }
                        else
                        {
                            Error(illegalCharacter, CharRep.InText(Current));
                        }
                        break;
                }
            }
            return Token(TKind.EOF, 0);
        }

        private void Error(string message, params object[] args)
        {
            throw new DiagnosticException(new SyntaxError(GetLocation(), string.Format(message, args)));
        }

        private Token Special()
        {
            Assert(Current == '%');
            offset += 1;
            return Identifier();
        }

        private Token Identifier()
        {
            Assert(Letter(Current));
            offset += 1;
            while (More && LetterOrDigit(Current))
            {
                offset += 1;
            }
            while (More && (Current == '-' || Current == '_') && OneMore && Letter(Next))
            {
                offset += 2;
                while (More && LetterOrDigit(Current))
                {
                    offset += 1;
                }
            }

            var text = GetLocation(0).GetText();

            if (text == "epsilon" || text == "ε")
            {
                return Token(TKind.Epsilon, 0);
            }

            return Token(TKind.Name, 0);
        }

        private static bool Letter(int c)
        {
            return 'a' <= c && c <= 'z' || 'A' <= c && c <= 'Z' || c == 'ε';
        }

        private static bool DecimalDigit(int c)
        {
            return '0' <= c && c <= '9';
        }

        private static bool LetterOrDigit(int c)
        {
            return Letter(c) || DecimalDigit(c);
        }

        private static bool HexDigit(int c)
        {
            return '0' <= c && c <= '9' || 'a' <= c && c <= 'f' || 'A' <= c && c <= 'F';
        }

        private Token Literal()
        {
            Assert(Current == '\'');
            var payload = new StringBuilder();
            offset += 1;
            if (!More)
            {
                Error(eofInLiteral);
            }
            while (true)
            {
                switch (Current)
                {
                    case '\'':
                        if (offset - start < 2)
                        {
                            Error(shortLiteral);
                        }
                        return Token(TKind.Literal, payload: payload.ToString());
                    case '\\':
                        offset += 1;
                        if (!More)
                        {
                            Error(incompleteEscape);
                            break;
                        }
                        switch (Current)
                        {
                            case 'u':
                                {
                                    if (!More)
                                    {
                                        Error(incompleteEscape);
                                        break;
                                    }
                                    offset += 1;
                                    if (Current != '{')
                                    {
                                        Error(illegalUnicodeEscape);
                                    }
                                    offset += 1;
                                    var begin = offset;
                                    while (More && HexDigit(Current))
                                    {
                                        offset += 1;
                                    }
                                    if (Current != '}')
                                    {
                                        Error(illegalUnicodeEscape);
                                    }
                                    var text = Source.GetText(begin, offset - begin);
                                    if (text.Length == 0 || text.Length > 6)
                                    {
                                        Error(illegalUnicodeEscape);
                                    }
                                    if (!int.TryParse(text, NumberStyles.HexNumber, null, out var utf32))
                                    {
                                        Error(illegalUnicodeEscape);
                                    }
                                    if (utf32 < 0 || utf32 > 0x10FFFF)
                                    {
                                        Error(illegalUnicodeEscape);
                                    }
                                    offset += 1;
                                    payload.Append(char.ConvertFromUtf32(utf32));
                                    break;
                                }
                            case '\\':
                                payload.Append('\\');
                                offset += 1;
                                break;
                            case '\'':
                                payload.Append('\'');
                                offset += 1;
                                break;
                            case 'a':
                                payload.Append('\a');
                                offset += 1;
                                break;
                            case 'b':
                                payload.Append('\b');
                                offset += 1;
                                break;
                            case 'f':
                                payload.Append('\f');
                                offset += 1;
                                break;
                            case 'n':
                                payload.Append('\n');
                                offset += 1;
                                break;
                            case 't':
                                payload.Append('\t');
                                offset += 1;
                                break;
                            case 'r':
                                payload.Append('\r');
                                offset += 1;
                                break;
                            case 'v':
                                payload.Append('\v');
                                offset += 1;
                                break;
                            default:
                                payload.Append(char.ConvertFromUtf32(Current));
                                offset += 1;
                                break;
                        }
                        break;
                    default:
                        if (char.IsControl((char)Current))
                        {
                            start = offset;
                            Error(illegalInLiteral, CharRep.InText(Current));
                        }
                        payload.Append(char.ConvertFromUtf32(Current));
                        offset += 1;
                        break;
                }
                if (!More)
                {
                    Error(eofInLiteral);
                }
            }

        }

        private Location GetLocation(int skip = 1)
        {
            return Location.From(Source, start, offset - start + skip);
        }

        private Token Token(TKind kind, int skip = 1, string payload = "")
        {
            var token =  new Token(kind, GetLocation(skip), payload);
            offset += skip;
            return token;
        }

        private void SkipWhitespace()
        {
            start = offset;
            var done = false;
            while (!done && More)
            {
                switch(Current)
                {
                    case ' ':
                    case '\t':
                    case '\r':
                        offset += 1;
                        break;
                    case '\n':
                        offset += 1;
                        break;
                    case '/' when OneMore && Next == '/':
                        offset += 2;
                        while (More)
                        {
                            if (Current == '\n')
                            {
                                offset += 1;
                                break;
                            }
                            offset += 1;
                        }
                        break;
                    case '/' when OneMore && Next == '*':
                        SkipBlockComment();
                        break;
                    default:
                        done = true;
                        break;
                }
            }
            start = offset;

            void SkipBlockComment()
            {
                offset += 2;
                while (More)
                {
                    if (More && Current == '*')
                    {
                        offset += 1;
                        if (More && Current == '/')
                        {
                            offset += 1;
                            break;
                        }
                        else
                        {
                            offset += 1;
                        }
                    }
                    if (More)
                    {
                        offset += 1;
                    }
                }
            }
        }

        private bool More => offset < Source.Length;
        private bool OneMore => offset + 1 < Source.Length;

    }
}
