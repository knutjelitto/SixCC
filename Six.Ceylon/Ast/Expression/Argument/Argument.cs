using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface Argument : AstNode
    {
        public record Expression(Ast.Expr Expr) : Argument, Ast.Expr;

        public record Spread(Ast.Expr Expr) : Argument;
    }

    public abstract record class Arguments : AstNode
    {
        public record Positional(ArgumentList Sequenced) : Arguments;
        public record Patterned(ArgumentList Structured, ArgumentList Sequenced) : Arguments;
    }
}
