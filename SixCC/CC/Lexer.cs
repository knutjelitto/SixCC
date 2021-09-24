using SixCC.CC.Errors;
using SixCC.Runtime.Concretes;
using SixCC.Runtime.Structures;

namespace SixCC.CC
{
    internal class Lexer
    {
        private const string eofInLiteral = "premature eof in string literal";
        private const string shortLiteral = "empty string literal";
        private const string incompleteEscape = "incomplete escape sequence";
        private const string illegalCharacter = "illegal character";

        public Lexer(ISource source)
        {
            Source = source;
            start = 0;
            offset = 0;
        }

        public ISource Source { get; }

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
                    case '?':
                        return Token(TKind.Quest);
                    case '!':
                        return Token(TKind.Exclam);
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
                    default:
                        if (Letter(Current))
                        {
                            return Identifier();
                        }
                        else
                        {
                            Error(illegalCharacter);
                        }
                        break;
                }
            }
            return Token(TKind.EOF, 0);
        }

        private void Error(string message)
        {
            throw new DiagnosticException(new SyntaxError(GetLocation(), message));
        }

        private Token Identifier()
        {
            Debug.Assert(Letter(Current));
            offset += 1;
            while (More && LetterOrDigit(Current))
            {
                offset += 1;
            }
            while (More && Current == '-' && OneMore && Letter(Next))
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
            return ('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z') || c == 'ε';
        }

        private static bool Digit(int c)
        {
            return '0' <= c && c <= '9';
        }

        private static bool LetterOrDigit(int c)
        {
            return Letter(c) || Digit(c);
        }

        private Token Literal()
        {
            Debug.Assert(Current == '\'');
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
                        return Token(TKind.Literal);
                    case '\\':
                        offset += 1;
                        if (!More)
                        {
                            Error(incompleteEscape);
                            break;
                        }
                        switch (Current)
                        {
                            case '\\':
                            case '\'':
                            case 't':
                            case 'r':
                            case 'n':
                                offset += 1;
                                break;
                        }
                        break;
                    default:
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

        private Token Token(TKind kind, int skip = 1)
        {
            var token =  new Token(kind, GetLocation(skip));
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
                    case '\r':
                        offset += 1;
                        break;
                    case '\n':
                        offset += 1;
                        Source.IndexNewline(offset);
                        break;
                    case '/' when OneMore && Next == '/':
                        offset += 2;
                        while (More)
                        {
                            if (Current == '\n')
                            {
                                offset += 1;
                                Source.IndexNewline(offset);
                                break;
                            }
                            offset += 1;
                        }
                        break;
                    default:
                        done = true;
                        break;
                }
            }
            start = offset;
        }

        private bool More => offset < Source.Length;
        private bool OneMore => offset + 1 < Source.Length;

    }
}
