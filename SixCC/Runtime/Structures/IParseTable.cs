using SixCC.Runtime.Concretes;
using System.Collections.Generic;

namespace SixCC.Runtime.Structures
{
    public interface IParseTable
    {
        IState this[int stateNo] { get; }

        IStateItem this[int stateNo, int symNo] { get; }

        int NumberOfStates { get; }
        int NumberOfSymbols { get; }
        int NumberOfTerminals { get; }
        int NumberOfNonterminals => NumberOfSymbols - NumberOfTerminals;
    }
}
