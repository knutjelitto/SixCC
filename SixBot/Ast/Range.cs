using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class Range : Expression
    {
        public Range(Expression start, Expression end)
        {
            Start = start;
            End = end;
        }

        public Expression Start { get; }
        public Expression End { get; }
    }
}
