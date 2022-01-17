using Six.Gen.Ebnf;

namespace Six.Gen
{
    internal static class CsWriter
    {
        public static string CsId(this RuleOp rule)
        {
            return rule.Name.CsId();
        }

        public static string CsId(this string identifier)
        {
            var special = identifier.StartsWith("%");

            if (special)
            {
                identifier = identifier.Substring(1);
            }
            var parts = identifier.Split('-');

            return (special ? "_" : "") + string.Join(string.Empty, parts.Select(part => part.Cap()));
        }

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

        public static string RuleId(this CoreOp op)
        {
            if (op is RuleOp rule)
            {
                return rule.Name.RuleId();
            }
            else
            {
                return $"__Matchers[{op.Id}]";
            }
        }

        public static string DfaId(this CoreOp op)
        {
            if (op is RuleOp rule)
            {
                return rule.Name.RuleId() + "_DFA";
            }
            else
            {
                return $"__Matchers_{op.Id}_DFA";
            }
        }

        private static string RuleId(this string identifier)
        {
            if (identifier.StartsWith("%"))
            {
                return "__" + identifier.Substring(1).Cap();
            }

            var parts = identifier.Split('-', '_');

            return "_" + string.Join(string.Empty, parts.Take(1).Concat(parts.Skip(1).Select(part => part.Cap())));
        }

        private static string Cap(this string name)
        {
            var first = char.ToUpperInvariant(name.First()).ToString();
            var rest = string.Join(string.Empty, name.Skip(1).Select(chr => char.ToLowerInvariant(chr)));

            return first + rest;
        }
    }
}
