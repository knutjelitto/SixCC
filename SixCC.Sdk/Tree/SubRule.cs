using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public sealed class SubRule : Node, IExpression
    {
        public SubRule(Name name, IExpression expression)
        {
            Name = name;
            Expression = expression;
        }

        public Name Name { get; }
        public IExpression Expression { get; }
        public IEnumerable<IExpression> Children => Enumerable.Repeat(Expression, 1);

        public override void Dump(IndentWriter writer)
        {
            writer.Write($"{{{Name}: ");
            Expression.Dump(writer);
            writer.Write($"}}");
        }

        public FA GetFA()
        {
            throw new NotImplementedException();
        }

        private bool Equals(SubRule other)
        {
            return Equals(Name, other.Name) && Equals(Expression, other.Expression);
        }

        public override bool Equals(object? obj) => obj is SubRule other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(Name, Expression);
    }
}
