using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal abstract class Expression
    {
        public static Seq operator+(Expression left, Expression right)
        {
            if (left is Seq seq)
            {
                return new Seq(seq.Expressions.Concat(Enumerable.Repeat(right, 1)).ToArray());
            }
            else
            {
                return new Seq(left, right);
            }
        }

        public static Alt operator |(Expression left, Expression right)
        {
            if (left is Alt seq)
            {
                return new Alt(seq.Expressions.Concat(Enumerable.Repeat(right, 1)).ToArray());
            }
            else
            {
                return new Alt(left, right);
            }
        }

        public static Rule operator <=(string name, Expression expression)
        {
            return new Rule(name, expression);
        }

        public static Rule operator >=(string name, Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}
