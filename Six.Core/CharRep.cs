using System;
using System.Globalization;
using System.Linq;

namespace Six.Core
{
    public static class CharRep
    {
        public static string InText(string value)
        {
            return string.Join(string.Empty, value.Select(v => Convert(v)));
        }

        public static string InText(int value)
        {
            return Convert(value);
        }

        public static string InRange(int value)
        {
            var result = Convert(value);

            if (!result.StartsWith("U+", StringComparison.InvariantCulture))
            {
                return $"'{result}'";
            }
            return $"{result}";
        }

        public static string Convert(int value)
        {
            if (value <= char.MaxValue)
            {
                switch ((char)value)
                {
                    case '\0':
                        return "\\0";
                    case '\a':
                        return "\\a";
                    case '\b':
                        return "\\b";
                    case '\f':
                        return "\\f";
                    case '\n':
                        return "\\n";
                    case '\r':
                        return "\\r";
                    case '\t':
                        return "\\t";
                    case '\v':
                        return "\\v";
                    case '\'':
                        return "\\'";
                    case '\"':
                        return "\\\"";
                    case '\\':
                        return "\\\\";

                    default:
                        if (IsSpecial(value))
                        {
                            return "U+" + value.ToString("X4", CultureInfo.InvariantCulture);
                        }

                        return $"{(char)value}";
                }
            }

            return "U+" + value.ToString("X4", CultureInfo.InvariantCulture);
        }

        public static bool IsSpecial(int value)
        {
            switch (char.GetUnicodeCategory((char)value))
            {
                case UnicodeCategory.Control:
                case UnicodeCategory.Format:
                case UnicodeCategory.LineSeparator:
                case UnicodeCategory.ModifierLetter:
                case UnicodeCategory.ModifierSymbol:
                case UnicodeCategory.NonSpacingMark:
                case UnicodeCategory.OtherNotAssigned:
                case UnicodeCategory.ParagraphSeparator:
                case UnicodeCategory.PrivateUse:
                case UnicodeCategory.SpacingCombiningMark:
                case UnicodeCategory.Surrogate:
                    return true;

                case UnicodeCategory.ClosePunctuation:
                case UnicodeCategory.ConnectorPunctuation:
                case UnicodeCategory.CurrencySymbol:
                case UnicodeCategory.DashPunctuation:
                case UnicodeCategory.DecimalDigitNumber:
                case UnicodeCategory.EnclosingMark:
                case UnicodeCategory.FinalQuotePunctuation:
                case UnicodeCategory.InitialQuotePunctuation:
                case UnicodeCategory.LetterNumber:
                case UnicodeCategory.LowercaseLetter:
                case UnicodeCategory.MathSymbol:
                case UnicodeCategory.OpenPunctuation:
                case UnicodeCategory.OtherLetter:
                case UnicodeCategory.OtherNumber:
                case UnicodeCategory.OtherPunctuation:
                case UnicodeCategory.OtherSymbol:
                case UnicodeCategory.SpaceSeparator:
                case UnicodeCategory.TitlecaseLetter:
                case UnicodeCategory.UppercaseLetter:
                default:
                    return false;
            }
        }
    }
}
