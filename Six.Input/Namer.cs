namespace Six.Input
{
    public class Namer
    {
        private readonly Dictionary<string, int> names = new();

        public void Clear()
        {
            names.Clear();
        }

        public string OneOrMore()
        {
            return GetName("one-or-more");
        }

        public string ZeroOrMore()
        {
            return GetName("zero-or-more");
        }

        public string ZeroOrOne()
        {
            return GetName("zero-or-one");
        }

        public string Alternative()
        {
            return GetName("alternative");
        }

        public string GetName(string stem)
        {
            if (!names.TryGetValue(stem, out var count))
            {
                count = 1;
                names.Add(stem, count);
            }
            else
            {
                count += 1;
                names[stem] = count;
            }
            return $"{stem}-{count}";
        }
    }
}
