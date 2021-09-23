using SixCC.Runtime.Structures;

namespace SixCC.CC
{
    internal class Token
    {
        public Token(TKind kind, ILocation location)
        {
            Kind = kind;
            Location = location;
        }

        public TKind Kind { get; }
        public ILocation Location { get; }
        public string Text => Location.GetText();

        public override string ToString()
        {
            return $"{Kind,-11}: {Location}";
        }
    }
}
