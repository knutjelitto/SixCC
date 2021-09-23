using System.Globalization;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Errors;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public class UcCodepoint : Atom
    {
        public UcCodepoint(string text)
        {
            Text = text;

            if (text.ToUpper().StartsWith("\\U{"))
            {
                if (int.TryParse(Text.Substring(3, Text.Length - 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value))
                {
                    Value = value;
                    return;
                }
            }
            else if (text.ToUpper().StartsWith("U+"))
            {
                if (int.TryParse(Text.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value))
                {
                    Value = value;
                    return;
                }
            }

            throw new TreeException($"can't convert `{text}` to a valid unicode codepoint");
        }

        public string Text { get; }
        public int Value { get; }

        public override FA GetFA()
        {
            return FA.From(Value);
        }

        public override void Dump(IndentWriter output)
        {
            output.Write(Text);
        }
    }
}
