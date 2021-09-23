using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.CC.Structure
{
    internal class Range : Symbol
    {
        public Range(ILocation location, Literal left, Literal right)
            : base(location)
        {
            Left = left;
            Right = right;

            IsNullable = false;
            IsTerminal = true;
        }

        public Literal Left { get; set; }
        public Literal Right { get; set; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return builder.Range(Decode(Left.Decoded), Decode(Right.Decoded));
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{Left}..{Right}";

        private static int Decode(string singleton)
        {
            if (singleton.Length == 1 && !char.IsSurrogate(singleton[0]))
            {
                return singleton[0];
            }
            else if (singleton.Length == 2 && char.IsSurrogatePair(singleton, 0))
            {
                return char.ConvertToUtf32(singleton, 0);
            }
            else
            {
                throw new InvalidCastException("illegal character literal");
            }
        }
    }
}
