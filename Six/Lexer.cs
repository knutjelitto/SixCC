using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Six
{
    public class Lexer
    {
        public Lexer(Source source)
        {
            Source = source;
            Before = 0;
            Start = 0;
            Offset = 0;
            Source.IndexLine(Offset);
        }

        public Source Source { get; }
        public int Before { get; private set; }
        public int Start { get; private set; }
        public int Offset { get; private set; }
        public int Length => Offset - Start;

        private bool More => Offset < Source.Length;
        private char Current => At(Offset);
        private char Next => At(Offset + 1);

        private char At(int index)
        {
            if (index < Source.Length)
            {
                return Source.Text[index];
            }
            return '\0';
        }

        public Token GetNext()
        {
            Start = Before = Offset;
            SkipWhitespace();
            Start = Offset;
            if (!More)
            {
                return Token(TokenKind.EOF);
            }
            switch (Current)
            {
                case '{':
                    return Token1(TokenKind.LeftCurly);

                case '}':
                    return Token1(TokenKind.RightCurly);

                case '(':
                    return Token1(TokenKind.LeftParen);

                case ')':
                    return Token1(TokenKind.RightParen);

                case '[':
                    return Token1(TokenKind.LeftSquare);

                case ']':
                    return Token1(TokenKind.RightSquare);

                case '+':
                    Offset += 1;
                    if (Match('='))
                    {
                        return Token(TokenKind.AddAssign);
                    }
                    if (Match('+'))
                    {
                        return Token(TokenKind.Inc);
                    }
                    return Token(TokenKind.Add);

                case '-':
                    Offset += 1;
                    if (Match('='))
                    {
                        return Token(TokenKind.SubAssign);
                    }
                    if (Match('-'))
                    {
                        return Token(TokenKind.Dec);
                    }
                    if (Match('>'))
                    {
                        return Token(TokenKind.Lambda);
                    }
                    return Token(TokenKind.Sub);

                case '*':
                    Offset += 1;
                    if (Match('='))
                    {
                        return Token(TokenKind.MulAssign);
                    }
                    return Token(TokenKind.Mul);

                case '/':
                    Offset += 1;
                    if (Match('='))
                    {
                        return Token(TokenKind.DivAssign);
                    }
                    if (Match('%'))
                    {
                        return Token(TokenKind.DivRem);
                    }
                    Offset += 1;
                    return Token(TokenKind.Div);

                case '%':
                    Offset += 1;
                    if (Match('='))
                    {
                        return Token(TokenKind.ModAssign);
                    }
                    return Token(TokenKind.Mod);

                case '&':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '&')
                        {
                            Offset += 1;
                            if (More && Current == '=')
                            {
                                Offset += 1;
                                return Token(TokenKind.CondAndAssign);
                            }
                            return Token(TokenKind.CondAnd);
                        }
                        if (Current == '=')
                        {
                            Offset += 1;
                            return Token(TokenKind.BitAndAssign);
                        }
                    }
                    return Token(TokenKind.BitAnd);

                case '^':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '^')
                        {
                            Offset += 1;
                            return Token(TokenKind.CondXor);
                        }
                    }
                    return Token(TokenKind.BitXor);

                case '|':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '|')
                        {
                            Offset += 1;
                            return Token(TokenKind.CondOr);
                        }
                    }
                    return Token(TokenKind.BitOr);

                case '=':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '=')
                        {
                            Offset += 1;
                            return Token(TokenKind.CompEQ);
                        }
                    }
                    return Token(TokenKind.Assign);

                case '!':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '=')
                        {
                            Offset += 1;
                            return Token(TokenKind.CompNE);
                        }
                    }
                    return Token(TokenKind.Not);

                case '<':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '=')
                        {
                            if (More && Current == '>')
                            {
                                return Token1(TokenKind.CompOrder);
                            }
                            return Token1(TokenKind.CompLE);
                        }
                        if (Current == '<')
                        {
                            Offset += 1;
                            if (More && Current == '=')
                            {
                                return Token1(TokenKind.ShlAssign);
                            }
                            return Token(TokenKind.Shl);
                        }
                    }
                    return Token(TokenKind.CompLT);

                case '>':
                    Offset += 1;
                    if (More)
                    {
                        if (Match('='))
                        {
                            return Token(TokenKind.CompGE);
                        }
                        if (Match('>'))
                        {
                            if (Match('>'))
                            {
                                if (Match('='))
                                {
                                    return Token(TokenKind.UShrAssign);
                                }
                                return Token(TokenKind.UShr);
                            }
                            if (Match('='))
                            {
                                return Token(TokenKind.ShrAssign);
                            }
                            return Token(TokenKind.Shr);
                        }
                    }
                    return Token(TokenKind.CompGT);

                case ',':
                    return Token1(TokenKind.Comma);

                case ';':
                    return Token1(TokenKind.SemiColon);

                case '$':
                    return Token1(TokenKind.StringFile);

                case '#':
                    return Token1(TokenKind.BinaryFile);

                case '@':
                    return Token1(TokenKind.At);

                case '?':
                    Match();
                    if (Match(':'))
                    {
                        if (Match('='))
                        {
                            return Token(TokenKind.CondElseAssign);
                        }
                        return Token(TokenKind.CondElse);
                    }
                    if (Match('='))
                    {
                        return Token(TokenKind.CondNotNullAssign);
                    }
                    return Token(TokenKind.Cond);

                case ':':
                    Match();
                    if (Match('='))
                    {
                        return Token(TokenKind.CondAssign);
                    }
                    return Token(TokenKind.Colon);

                case '.':
                    Offset += 1;
                    if (More)
                    {
                        if (Current == '.')
                        {
                            Offset += 1;
                            if (More)
                            {
                                switch (Current)
                                {
                                    case '.': return Token1(TokenKind.Elipsis);
                                    case '/': return Token1(TokenKind.ParentDir);
                                }
                            }
                            return Token(TokenKind.DotDot);
                        }
                        if (Current == '/')
                        {
                            return Token1(TokenKind.CurrentDir);
                        }
                    }
                    return Token(TokenKind.Dot);

                case '"':
                    return String();

                default:
                    if (char.IsLetter(Current))
                    {
                        return IdentifierOrKeyword();
                    }
                    if (char.IsDigit(Current))
                    {
                        return Number();
                    }
                    var message = $"{Source.Report(Offset)}: illegal character '{Current}'";
                    Console.WriteLine(message);
                    throw new NotImplementedException(message);
            }
        }

        private Token Token1(TokenKind kind)
        {
            Offset += 1;
            return Token(kind);
        }

        private Token Token(TokenKind kind)
        {
            return new Token(kind, new Span(Source, Before, Start, Length));
        }

        private Token Number()
        {
            while (char.IsDigit(Current))
            {
                Offset += 1;
            }
            return Token(TokenKind.LitInt);
        }

        private Token IdentifierOrKeyword()
        {
            bool lower = char.IsLower(Current);

            while (char.IsLetterOrDigit(Current))
            {
                Offset += 1;
            }
            if (Current == ':' && char.IsLetter(Next))
            {
                Offset += 1;
                while (char.IsLetterOrDigit(Current))
                {
                    Offset += 1;
                }
            }
            if (!TokenInfo.Keywords.TryGetValue(Source.Text[Start..Offset], out var kind))
            {
                kind = lower ? TokenKind.LIdentifier : TokenKind.UIdentifier;
            }
            return Token(kind);
        }

        private Token String()
        {
            Debug.Assert(Current == '"');
            Offset += 1;
            while (More)
            {
                if (Current == '"')
                {
                    Offset += 1;
                    return Token(TokenKind.StringLiteral);
                }
                if (Current == '\\')
                {
                    throw new NotImplementedException();
                }
                Offset += 1;
            }
            throw new InvalidOperationException("end of file in string literal");
        }

        private void SkipSinglelineComment()
        {
            while (More)
            {
                if (Current == '\n')
                {
                    Source.IndexLine(Offset + 1);
                    Offset += 1;
                    return;
                }
                Offset += 1;
            }
        }

        private void SkipMultilineComment()
        {
            while (More)
            {
                if (Current == '*')
                {
                    Offset += 1;
                    if (More && Current == '/')
                    {
                        Offset += 1;
                        return;
                    }
                }
                else
                {
                    if (Current == '\n')
                    {
                        Source.IndexLine(Offset + 1);
                    }
                    Offset += 1;
                }
            }

            throw new InvalidOperationException("end of file in multiline comment");
        }

        private void SkipWhitespace()
        {
            while (More)
            {
                switch (Current)
                {
                    case ' ':
                    case '\t':
                    case '\r':
                        Offset += 1;
                        break;
                    case '\n':
                        Offset += 1;
                        Source.IndexLine(Offset);
                        break;
                    case '/':
                        if (Offset + 1 < Source.Length)
                        {
                            if (Source.Text[Offset + 1] == '/')
                            {
                                Offset += 2;
                                SkipSinglelineComment();
                            }
                            else if (Source.Text[Offset + 1] == '*')
                            {
                                Offset += 2;
                                SkipMultilineComment();
                            }
                            continue;
                        }
                        return;
                    default:
                        return;
                }
            }
        }

        private bool Match()
        {
            if (Offset < Source.Length)
            {
                Offset += 1;
                return true;
            }
            return false;
        }

        private bool Match(char character)
        {
            if (Offset < Source.Length && Current == character)
            {
                Offset += 1;
                return true;
            }
            return false;
        }
    }
}
