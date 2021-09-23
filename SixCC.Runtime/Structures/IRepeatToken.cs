using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Runtime.Structures
{
    public interface IRepeatToken : INonterminalToken
    {
        void Add(IToken token);
    }
}
