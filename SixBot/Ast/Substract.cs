using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class Substract : Expression
    {
        public Substract(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public Expression Left { get; }
        public Expression Right { get; }
    }
}
