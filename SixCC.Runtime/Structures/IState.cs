using System;
using System.Collections.Generic;

namespace SixCC.Runtime.Structures
{
    public interface IState : IReadOnlyList<IStateItem>
    {
        IEnumerable<IStateItem> Terminals { get; }
        IEnumerable<IStateItem> Nonterminals { get; }
        IEnumerable<IStateItem> All { get; }
    }
}
