using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Literal : Symbol
    {
        private string? decoded = null;

        public Literal(ILocation location, string text)
            : base(location)
        {
            Text = text;

            IsNullable = false;
            IsTerminal = true;
        }

        public string Text { get; }
        public string Decoded => decoded ??= Decode();

        public override NFA GetTerminalNfa(Factory builder)
        {
            return builder.Sequence(Decoded.Select(s => (int)s));
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => Text;

        private string Decode()
        {
            var builder = new StringBuilder();
            for (var i = 1; i < Text.Length - 1; i += 1)
            {
                if (Text[i] == '\\')
                {
                    i += 1;
                    switch (Text[i])
                    {
                        case '\\':
                        case '\'':
                            builder.Append(Text[i]);
                            break;
                        case 't':
                            builder.Append('\t');
                            break;
                        case 'r':
                            builder.Append('\r');
                            break;
                        case 'n':
                            builder.Append('\n');
                            break;
                        case 'u':
                            i += 1;
                            Debug.Assert(Text[i] == '{');
                            int codepoint = 0;
                            i += 1;
                            do
                            {
                                codepoint = codepoint * 16 + Hex(i);
                                i += 1;
                            }
                            while (Text[i] != '}');
                            i += 1;
                            builder.Append(char.ConvertFromUtf32(codepoint));
                            break;
                    }
                }
                else
                {
                    builder.Append(Text[i]);
                }
            }
            return builder.ToString();

            int Hex(int i)
            {
                switch (Text[i])
                {
                    case char c when '0' <= c && c <= '9':
                        return c - '0';
                    case char c when 'A' <= c && c <= 'F':
                        return c - 'A' + 10;
                    case char c when 'a' <= c && c <= 'a':
                        return c - 'a' + 10;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }
}
