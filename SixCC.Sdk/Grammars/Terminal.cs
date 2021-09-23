using System.Diagnostics;
using SixCC.Sdk.Automata;
using SixCC.Runtime.Structures;
using SixCC.Sdk.Tree;

namespace SixCC.Sdk.Grammars
{
    public class Terminal : Symbol, ITerminal
    {
        public Terminal(string name)
            : base(name)
        {
            IsFragment = false;
            Visual = string.Empty;
            Raw = TerminalRule.Nope;
        }

        public bool IsFragment { get; set; }
        public string Visual { get; set; }
        public TerminalRule Raw { get; set; }

        public FA GetDfa()
        {
            return Raw.Expression.GetFA()!.ToDfa().Minimize().RemoveDead();
        }

        public override string ToString()
        {
            return $"ˈ{ToShort()}ˈ";
        }

        public override string ToShort()
        {
            if (IsGenerated && !string.IsNullOrEmpty(Visual))
            {
                return $"{Visual}";
            }
            return $"{Name}";
        }
    }
}
