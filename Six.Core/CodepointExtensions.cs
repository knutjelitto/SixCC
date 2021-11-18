using System.Collections.Generic;
using System.Linq;
using static System.Diagnostics.Debug;

namespace Six.Core
{
    public static class CodepointExtensions
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

        public static IEnumerable<Codepoint> Codepoints(this char text)
        {
            int utf32;

            if (char.IsSurrogate(text))
            {
                utf32 = '�'; // replacement character
            }
            else
            {
                utf32 = text;
            }

            yield return new Codepoint(utf32);
        }

        public static Codepoint Codepoint(this int text)
        {
            if (text >= 0 && text <= 0x10FFFF)
            {
                if (text <= 0xFFFF && !char.IsSurrogate((char)text))
                {
                    return new Codepoint(text);
                }
            }
            return new Codepoint('�'); // replacement character
        }

        public static string ToString(this IEnumerable<Codepoint> cps)
        {
            return string.Join(string.Empty, cps.Select(cp => char.ConvertFromUtf32((int)cp)));
        }
    }
}
