using System.Diagnostics;
using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    [DebuggerDisplay("{ToString()}")]
    public abstract class Token : IToken
    {
        protected Token(ISymbol symbol)
        {
            Symbol = symbol;
        }

        public ISymbol Symbol { get; }

        public override string? ToString()
        {
            return $"{Symbol}"; 
        }
    }
}
