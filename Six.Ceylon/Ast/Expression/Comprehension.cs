using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface Comprehension : Argument
    {
        public sealed record For(Misc.ForIterator? Iterator, Comprehension Comprehension) : Comprehension;
        public sealed record If(ConditionList Conditions, Comprehension Comprehension) : Comprehension;
    }
}
