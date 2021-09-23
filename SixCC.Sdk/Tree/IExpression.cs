using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Grammars;

namespace SixCC.Sdk.Tree
{
    public interface IExpression : ICanDump
    {
        FA? GetFA();

        IEnumerable<IExpression> Children { get; }
    }
}
