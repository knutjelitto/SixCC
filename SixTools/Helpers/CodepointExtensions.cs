namespace SixTools.Helpers
{
    public struct Codepoint
    {
        private readonly int value;

        public Codepoint(int value)
        {
            this.value = value;
        }

        public static explicit operator int(Codepoint cp)
        {
            return cp.value;
        }

        public override string ToString()
        {
            return char.ConvertFromUtf32(value);
        }
    }

    internal static class CodepointExtensions
    {
        public static IEnumerable<Codepoint> Codepoints(this string text)
        {
            var i = 0;
            while (i < text.Length)
            {
                int utf32;
                if (char.IsSurrogatePair(text, i))
                {
                    utf32 = char.ConvertToUtf32(text, i);
                    Assert(char.ConvertFromUtf32(utf32).Length == 2);
                    i += 2;
                }
                else if (char.IsSurrogate(text, i))
                {
                    utf32 = '�'; // replacement character
                    i += 1;
                }
                else
                {
                    utf32 = text[i];
                    i += 1;
                }

                yield return new Codepoint(utf32);
            }
        }
    }
}
