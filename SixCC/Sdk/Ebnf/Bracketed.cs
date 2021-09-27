using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.Sdk.Ebnf
{
    public abstract class Bracketed : Symbol
    {
        public Bracketed(ILocation location)
            : base(location)
        {
        }
    }
}
