using Six.Core;

namespace Six.Runtime.Types
{
    public interface IRLocated
    {
        int Core { get; }
        int End { get; }
        Source Source { get; }
        int Start { get; }
        string Text { get; }
    }
}