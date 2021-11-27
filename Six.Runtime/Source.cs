namespace Six.Runtime
{
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
    }
}
