using Six.Core;

namespace Six.Runtime.Sppf
{
    public class RuleIndex
    {
        private Dictionary<string, SortedSet<string>> rules = new();

        public RuleIndex(IEnumerable<string> presetNames)
        {
            foreach (var presetName in presetNames)
            {
                rules.Add(presetName, new SortedSet<string>());
            }
        }

        public void Add(string name, string location)
        {
            if (!rules.TryGetValue(name, out var locations))
            {
                locations = new SortedSet<string>();
                rules.Add(name, locations);
            }
            locations.Add(location);
        }

        public void Dump(Writer writer)
        {
            foreach (var name in rules.Keys.Where(n => rules[n].Count <= 500).OrderBy(n => rules[n].Count))
            {
                writer.WriteLine(name);
                writer.Indent(() =>
                {
                    foreach (var location in rules[name])
                    {
                        writer.WriteLine(location);
                    }
                });
            }
        }
    }
}
