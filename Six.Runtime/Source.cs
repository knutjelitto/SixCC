namespace Six.Runtime
{
    [DebuggerStepThrough]
    public record struct Source(string Text)
    {
        public bool Match(int offset, string text)
        {
            if (offset + text.Length <= Text.Length)
            {
                return Text.Substring(offset, text.Length) == text;
            }
            return false;
        }

        public bool Match(int offset, int cp)
        {
            Assert(cp <= 0xFFFF);
            if (offset < Text.Length)
            {
                return Text[offset] == cp; ;
            }
            return false;
        }

        public int At(int offset)
        {
            if (offset < Text.Length)
            {
                return Text[offset];
            }
            return -1;
        }
    }
}
