using System.Collections.Generic;
using System.Linq;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public class Promote : Node, IExpression
    {
        public Promote(IExpression expression)
        {
            Expression = expression;
        }

        public IEnumerable<IExpression> Children => Enumerable.Repeat(Expression, 1);

        public IExpression Expression { get; }

        public override void Dump(IndentWriter writer)
        {
            writer.Write("^");
            Expression.Dump(writer);
        }

        public FA? GetFA()
        {
            return Expression.GetFA();
        }
    }
}
