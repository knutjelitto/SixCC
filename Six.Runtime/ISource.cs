namespace Six.Runtime
{
    public interface ISource
    {
        string Text { get; }
        int At(int offset);
        bool Match(int offset, int cp);
        bool Match(int offset, string text);
    }
}