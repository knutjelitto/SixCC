using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Runtime.Structures
{
    public interface ITerminalToken : IToken
    {
        ILocation Location { get; }
        string Value { get; }
    }
}
