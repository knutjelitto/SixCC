using SixCC.Runtime.Parsing;
using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Commons
{
    public class CompactItem : IStateItem
    {
        public CompactItem(int value)
        {
            Coded = value;
        }

        public ParseAction Action => (ParseAction)(Coded & (int)ParseAction.Reduce);
        public int Number => Coded >> 2;
        public int Coded { get; }

        public override string ToString()
        {
            return $"[{Action} {Number}]";
        }
    }
}
