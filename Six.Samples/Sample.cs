namespace Six.Samples
{
    public class Sample
    {
        public Sample(string name, string fileContent, bool test)
        {
            Name = name;
            if (test)
            {
                var parts = fileContent.Split(Enumerable.Repeat(Environment.NewLine, 1).ToArray(), StringSplitOptions.RemoveEmptyEntries);
                Assert(1 <= parts.Length);
                if (parts.Length == 1)
                {
                    Count = -1;
                    Content = parts[0];
                    return;
                }
                else if (parts.Length == 2 && int.TryParse(parts[0], out var count))
                {
                    Count = count;
                    Content = parts[1];
                    return;
                }
            }

            Content = fileContent;
            Count = 1;
        }

        public string Name { get; }
        public string Content { get; }
        public int Count { get; }
    }
}
