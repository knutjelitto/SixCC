using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Expression : TreeNode
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
            public record Start(IRNode Tree) : String
            {
                private string? text;
                public string Text => text ??= ((RToken)Tree).StartText();
            }
            public record Mid(IRNode Tree) : String
            {
                private string? text;
                public string Text => text ??= ((RToken)Tree).MidText();
            }
            public record End(IRNode Tree) : String
            {
                private string? text;
                public string Text => text ??= ((RToken)Tree).EndText();
            }
        }

        public record NaturalNumber(IRNode Tree) : Literal
        {
            private string? text;
            public string Text => text ??= ((RToken)Tree).Text;
        }

        public sealed record InterpolationPart(IRNode Tree, String String, Expression Expression) : TreeNode;
        public sealed record InterpolationParts(IRNode Tree, IEnumerable<InterpolationPart> Items)
            : Many<InterpolationPart>(Tree, Items);
        public sealed record StringInterpolation(IRNode Tree, InterpolationParts Parts, String Last) : Expression;

        public interface OpExpression : Expression
        {
            Reference Op { get; }
        }

        public interface IInfix : OpExpression
        {
            Expression Left { get; }
            Expression Right { get; }
        }

        public interface IPrefix : OpExpression
        {
            Expression Expr { get; }
        }

        public sealed record Prefix(IRNode Tree, Reference Op, Expression Expr) : IPrefix;
        public sealed record Infix(IRNode Tree, Reference Op, Expression Left, Expression Right) : IInfix;

        public sealed record AndThen(IRNode Tree, Expression Left, Expression Right) : Expression;
        public sealed record OrElse(IRNode Tree, Expression Left, Expression Right) : Expression;

        public sealed record If(IRNode Tree, Conditions Conditions, Expression Then, Expression Else) : Expression;

        public sealed record Call(IRNode Tree, Expression Expr, Arguments Arguments) : Expression;
        public sealed record Select(IRNode Tree, Expression Expr, Reference Reference) : Expression;
        public sealed record NullsafeSelect(IRNode Tree, Expression Primary, Reference Reference) : Expression;

        public sealed record IsType(IRNode Tree, Type Type, Name Name) : Expression;

        public sealed record Conditions(IRNode Tree, IEnumerable<Expression> Items): Many<Expression>(Tree, Items);
    }

    public sealed record Arguments(IRNode Tree, IEnumerable<Expression> Items) : Many<Expression>(Tree, Items)
    {
        public Arguments(IRNode tree, params Expression[] items)
            : this(tree, items.AsEnumerable())
        { }
    }
}
