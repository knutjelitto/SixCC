using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Parsing
{
    public enum ParseAction
    {
        Error = 0,
        Accept = 1,
        Shift = 2,
        Reduce = 3,
    }
}
