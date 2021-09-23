using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal interface Node
    {
        ILocation Location { get; }
        string Head { get; }
    }
}
