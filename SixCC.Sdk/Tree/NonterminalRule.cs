using System.Collections.Generic;
using System.Linq;

using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public sealed class NonterminalRule : Nonterminal
    {
        private NonterminalRule(string name, IEnumerable<IExpression> alternates)
            : base(name)
        {
            Alternates = alternates.ToArray();
        }

        public IReadOnlyList<IExpression> Alternates { get; set; }

        public static NonterminalRule From(string name, IExpression expression)
        {
            if (expression is Alternates alternates)
            {
                return new NonterminalRule(name, alternates.Expressions);
            }
            return new NonterminalRule(name, Enumerable.Repeat(expression, 1));
        }

        public void Dump(IndentWriter output)
        {
            output.Indend($"{Name}", () =>
            {
                bool more = false;
                foreach (var expression in Alternates)
                {
                    if (more)
                    {
                        output.Write("| ");
                    }
                    else
                    {
                        output.Write(": ");
                    }
                    more = true;

                    expression.Dump(output);
                    output.WriteLine();
                }
                output.WriteLine(";");
            });
        }
    }
}
