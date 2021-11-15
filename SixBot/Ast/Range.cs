using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public override bool IsAtomic => false;
        public override string ToName() => $"({Start.ToName()}-{End.ToName()})";
    }
}
