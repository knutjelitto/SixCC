using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Expression : Node, Argument
    {
        public interface Literal : Expression
        {
            string Text { get; }
        }

        public interface String : Literal
        {
            public record Plain(IRNode Tree) : String
            {
                private string? text;
                public string Text => text ??= ((RToken)Tree).PlainText();
            }
            public record Verbatim(IRNode Tree) : String
            {
                private string? text;
                public string Text => text ??= ((RToken)Tree).VerbatimText();
            }
        }

        public record Number(IRNode Tree) : Literal
        {
            private string? text;
            public string Text => text ??= ((RToken)Tree).Text;
        }

        public interface Binary : Expression
        {
            Expression Left { get; }
            Expression Right { get; }
        }

        public interface Unary : Expression
        {
            Expression Expr { get; }
        }

        public sealed record Not(IRNode Tree, Expression Expr) : Unary;

        public sealed record Add(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Mul(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Equal(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record NotEqual(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Identical(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record NotIdentical(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Call(IRNode Tree, Expression Primary, Arguments Arguments) : Expression;
        public sealed record Select(IRNode Tree, Expression Primary, Reference Reference) : Expression;
    }
}
