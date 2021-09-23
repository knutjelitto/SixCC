namespace SixCC.Sdk.Earley
{
    public struct Extend
    {
        public Extend(int start, int next)
        {
            Start = start;
            Next = next;
        }

        public int Start { get; }
        public int Next { get; }
    }
}
