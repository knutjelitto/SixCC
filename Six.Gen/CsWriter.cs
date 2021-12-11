using Six.Gen.Ebnf;

namespace Six.Gen
{
    internal static class CsWriter
    {
        public static string CsString(this string text)
        {
            return $"\"{string.Join(string.Empty, text.Select(chr => Escape(chr)))}\"";

            //TODO: incomplete
            static string Escape(char chr)
            {
                switch (chr)
                {
                    case '"':
                        return "\\\"";
                    case '\\':
                        return "\\\\";
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
                    default:
                        if (chr == ' ')
                        {
                            return " ";
                        }
                        if (char.IsControl(chr) || char.IsSeparator(chr))
                        {
                            if (chr <= 0xFFFF)
                            {
                                return $"\\u{(int)chr:X04}";
                            }
                            else
                            {
                                return $"\\U{(int)chr:X08}";
                            }

                        }
                        return chr.ToString();
                }
            }
        }

        public static string RuleId(this string identifier)
        {
            if (identifier.StartsWith("%"))
            {
                return "__" + Cap(identifier.Substring(1));
            }

            var parts = identifier.Split('-', '_');

            return "_" + string.Join(string.Empty, parts.Take(1).Concat(parts.Skip(1).Select(part => Cap(part))));
        }

        public static string RuleId(this RuleOp op)
        {
            return op.Name.RuleId();
        }

        public static string RuleId(this RefOp op)
        {
            return op.Name.RuleId();
        }

        public static string DfaId(this RuleOp op)
        {
            return op.Name.RuleId() + "_DFA";
        }

        public static string Cap(string name)
        {
            var first = char.ToUpperInvariant(name.First()).ToString();
            var rest = string.Join(string.Empty, name.Skip(1).Select(chr => char.ToLowerInvariant(chr)));

            return first + rest;
        }
    }
}
