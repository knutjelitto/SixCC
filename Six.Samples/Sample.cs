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
                Assert(1 <= parts.Length && parts.Length <= 2);
                if (parts.Length == 1)
                {
                    Count = -1;
                    Content = parts[0];
                }
                else
                {
                    Count = int.Parse(parts[0].Trim());
                    Content = parts[1];
                }
            }
            else
            {
                Content = fileContent;
                Count = 1;
            }
        }

        public string Name { get; }
        public string Content { get; }
        public int Count { get; }
    }
}
