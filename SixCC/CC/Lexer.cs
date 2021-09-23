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
            current = 0;
        }

        public ISource Source { get; }

        private int start = 0;
        private int current = 0;

        public Token Next()
        {
            SkipWhitespace();
            if (More)
            {
                switch(Source[current])
                {
                    case '(':
                        return Token(TKind.LeftParent);
                    case ')':
                        return Token(TKind.RightParent);
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
                    case '.' when OneMore && Source[current + 1] == '.':
                        return Token(TKind.Range, 2);
                    case '.':
                        return Token(TKind.Any);
                    case '\'':
                        return Literal();
                    default:
                        if (Letter(Source[current]))
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
            Debug.Assert(Letter(Source[current]));
            current += 1;
            while (More && LetterOrDigit(Source[current]))
            {
                current += 1;
            }
            while (More && Source[current] == '-' && OneMore && Letter(Source[current+1]))
            {
                current += 2;
                while (More && LetterOrDigit(Source[current]))
                {
                    current += 1;
                }
            }

            var text = GetLocation(0).GetText();

            return Token(TKind.Name, 0);
        }

        private static bool Letter(char c)
        {
            return ('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z');
        }

        private static bool Digit(char c)
        {
            return '0' <= c && c <= '9';
        }

        private static bool LetterOrDigit(char c)
        {
            return Letter(c) || Digit(c);
        }

        private Token Literal()
        {
            Debug.Assert(Source[current] == '\'');
            current += 1;
            if (!More)
            {
                Error(eofInLiteral);
            }
            while (true)
            {
                switch (Source[current])
                {
                    case '\'':
                        if (current - start < 2)
                        {
                            Error(shortLiteral);
                        }
                        return Token(TKind.Literal);
                    case '\\':
                        current += 1;
                        if (!More)
                        {
                            Error(incompleteEscape);
                            break;
                        }
                        switch (Source[current])
                        {
                            case '\\':
                            case '\'':
                            case 't':
                            case 'r':
                            case 'n':
                                current += 1;
                                break;
                        }
                        break;
                    default:
                        current += 1;
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
            return Location.From(Source, start, current - start + skip);
        }

        private Token Token(TKind kind, int skip = 1)
        {
            var token =  new Token(kind, GetLocation(skip));
            current += skip;
            return token;
        }

        private void SkipWhitespace()
        {
            start = current;
            var done = false;
            while (!done && More)
            {
                switch(Source[current])
                {
                    case ' ':
                    case '\r':
                        current += 1;
                        break;
                    case '\n':
                        current += 1;
                        Source.IndexNewline(current);
                        break;
                    case '/' when OneMore && Source[current + 1] == '/':
                        current += 2;
                        while (More)
                        {
                            if (Source[current] == '\n')
                            {
                                current += 1;
                                Source.IndexNewline(current);
                                break;
                            }
                            current += 1;
                        }
                        break;
                    default:
                        done = true;
                        break;
                }
            }
            start = current;
        }

        private bool More => current < Source.Length;
        private bool OneMore => current + 1 < Source.Length;

    }
}
