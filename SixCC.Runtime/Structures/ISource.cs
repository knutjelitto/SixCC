namespace SixCC.Runtime.Structures
{
    public interface ISource
    {
        char this[int index] { get; }
        string Name { get; }
        (int lineNo, int colNo) GetLineCol(int index);
        string GetText(int start, int length);
        bool IsEnd(int index);
    }
}
