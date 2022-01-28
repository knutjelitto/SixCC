using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public abstract record Argument
    {
        public record Expression(IExpression Expr) : Argument, IExpression;
    }

    public abstract record class Arguments
    {
        public record Positional(ArgumentList Sequenced) : Arguments;
        public record Patterned(ArgumentList Structured, ArgumentList Sequenced) : Arguments;
    }
}
