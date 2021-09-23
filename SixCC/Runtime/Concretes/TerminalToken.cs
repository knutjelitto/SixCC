using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class TerminalToken : Token, ITerminalToken
    {
        public TerminalToken(ITerminal terminal, ILocation location)
            : base(terminal)
        {
            Location = location;
        }

        public ILocation Location { get; }
        public string Value => Location.GetText();
    }
}
