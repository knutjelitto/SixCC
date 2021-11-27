namespace Six.Core
{
    public interface ISource
    {
        int this[int offset] { get; }
        int Length { get; }
        string Name { get; }
        (int lineNumber, int columnNumber) GetLineAndColumn(int offset);
        string GetText(int start, int length);
        bool IsEnd(int index);
        void IndexNewline(int index);
    }
}
