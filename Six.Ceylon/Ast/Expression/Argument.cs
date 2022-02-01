using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface Argument : AstNode
    {
        public sealed record Expression(Ast.Expr Expr) : Argument, Ast.Expr;

        public sealed record Spread(Ast.Expr Expr) : Argument;

        public abstract record List(IEnumerable<Argument> Items) : ReadOnlyList<Argument>(Items);
    }

    public interface Arguments : AstNode
    {
        public record Positional(ArgumentList Sequenced) : Arguments;
        public record Patterned(ArgumentList Structured, ArgumentList Sequenced) : Arguments;
    }

    public sealed record ArgumentList(IEnumerable<Argument> Items) : Argument.List(Items);

}
