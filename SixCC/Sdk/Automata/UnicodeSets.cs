using SixCC.Core;
using System.Globalization;

namespace SixCC.Sdk.Automata
{
    public static class UnicodeSets
    {
        private const int MinCodePoint = 0;
        private const int MaxCodePoint = 0x10FFFF;

        public static IntegerSet Any() => new IntegerSet((MinCodePoint, MaxCodePoint));

        public static readonly CatergorySets Category = new CatergorySets();

        public static bool IsAny(IntegerSet set)
        {
            return set.Min == MinCodePoint &&
                   set.Max == MaxCodePoint &
                   set.Cardinality == (MaxCodePoint - MinCodePoint + 1);
        }

        public class CatergorySets
        {
            // https://docs.microsoft.com/de-de/dotnet/standard/base-types/character-classes-in-regular-expressions#SupportedUnicodeGeneralCategories
            private readonly (string name, UnicodeCategory[] categories)[] categories =
            {
                ("Lu", new[] {UnicodeCategory.UppercaseLetter}),
                ("Ll", new[] {UnicodeCategory.LowercaseLetter}),
                ("Lt", new[] {UnicodeCategory.TitlecaseLetter}),
                ("Lm", new[] {UnicodeCategory.ModifierLetter}),
                ("Lo", new[] {UnicodeCategory.OtherLetter}),
                ("L",
                    new[]
                    {
                        UnicodeCategory.UppercaseLetter, UnicodeCategory.LowercaseLetter, UnicodeCategory.TitlecaseLetter,
                        UnicodeCategory.ModifierLetter, UnicodeCategory.OtherLetter
                    }),
                ("Mn", new[] {UnicodeCategory.NonSpacingMark}),
                ("Mc", new[] {UnicodeCategory.SpacingCombiningMark}),
                ("Me", new[] {UnicodeCategory.EnclosingMark}),
                ("M",
                    new[]
                    {
                        UnicodeCategory.NonSpacingMark, UnicodeCategory.SpacingCombiningMark, UnicodeCategory.EnclosingMark
                    }),
            };

            public IntegerSet? this[string category]
            {
                get
                {
                    if (sets.TryGetValue(category, out var result))
                    {
                        return result;
                    }

                    var def = categories.FirstOrDefault(cat => cat.name == category);

                    if (def.name == null)
                    {
                        return null;
                    }

                    if (def.categories.Length == 1)
                    {
                        sets.Add(def.name, this[def.categories[0]]);

                        return this[def.categories[0]];
                    }

                    var set = new IntegerSet();

                    foreach (var unicodeCategory in def.categories)
                    {
                        set.Add(this[unicodeCategory]);
                    }

                    sets.Add(def.name, set);

                    return set;
                }
            }

            public IntegerSet this[UnicodeCategory category]
            {
                get
                {
                    var index = (int)category;
                    return basicSets[index] ?? (basicSets[index] = Generate(category));
                }
            }

            private static IntegerSet Generate(UnicodeCategory category)
            {
                var set = new IntegerSet();

                for (int ch = char.MinValue; ch <= char.MaxValue; ++ch)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory((char)ch) == category)
                    {
                        set.Add(ch);
                    }
                }

                return set;
            }

            private readonly IntegerSet[] basicSets = new IntegerSet[30];
            private readonly Dictionary<string, IntegerSet> sets = new();
        }
    }
}