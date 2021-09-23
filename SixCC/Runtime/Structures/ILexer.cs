using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Runtime.Structures
{
    public interface ILexer
    {
        bool IsEnd();
        ITerminalToken? Next(int stateId);
    }
}
