using System;
using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class TerminalSymbol : Symbol, ITerminal
    {
        public TerminalSymbol(int id, string name, bool visible, string visual)
            : base(id, name, visible)
        {
            Visual = visual;
        }

        public string Visual { get; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(Visual) ? Name : $"'{Visual}'";
        }
    }
}
