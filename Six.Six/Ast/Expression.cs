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

        public record Number(IRNode Tree) : Literal
        {
            private string? text;
            public string Text => text ??= ((RToken)Tree).Text;
        }

        public sealed record InterpolationPart(IRNode Tree, String String, Expression Expression) : TreeNode;
        public sealed record InterpolationParts(IRNode Tree, IEnumerable<InterpolationPart> Items)
            : Many<InterpolationPart>(Tree, Items);
        public sealed record StringInterpolation(IRNode Tree, InterpolationParts Parts, String Last) : Expression;


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
        public sealed record Neg(IRNode Tree, Expression Expr) : Unary;

        public sealed record AndThen(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record OrElse(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Add(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Sub(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Mul(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Div(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Rem(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Equal(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record NotEqual(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Identical(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record NotIdentical(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Greater(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record GreaterEqual(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Less(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record LessEqual(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Bounds(IRNode Tree, UpperLower Lower, Expression Expr, UpperLower Upper) : Expression;
        public record UpperLower(IRNode Tree, Expression Expr) : TreeNode;
        public record LowerLessBound(IRNode Tree, Expression Expr) : UpperLower(Tree, Expr);
        public record LowerLessEqualsBound(IRNode Tree, Expression Expr) : UpperLower(Tree, Expr);
        public record UpperLessBound(IRNode Tree, Expression Expr) : UpperLower(Tree, Expr);
        public record UpperLessEqualsBound(IRNode Tree, Expression Expr) : UpperLower(Tree, Expr);

        public sealed record If(IRNode Tree, Conditions Conditions, Expression Then, Expression Else) : Expression;
        public sealed record Then(IRNode Tree, Expression Left, Expression Right) : Binary;
        public sealed record Else(IRNode Tree, Expression Left, Expression Right) : Binary;

        public sealed record Call(IRNode Tree, Expression Expr, Arguments Arguments) : Expression;
        public sealed record Select(IRNode Tree, Expression Expr, Reference Reference) : Expression;
        public sealed record NullsafeSelect(IRNode Tree, Expression Primary, Reference Reference) : Expression;

        public sealed record IsType(IRNode Tree, Type Type, Name Name) : Expression;

        public sealed record Conditions(IRNode Tree, IEnumerable<Expression> Items): Many<Expression>(Tree, Items);
    }

    public sealed record Expressions(IRNode Tree, IEnumerable<Expression> Items) : Many<Expression>(Tree, Items)
    {
        public Expressions(IRNode tree, params Expression[] items)
            : this(tree, items.AsEnumerable())
        { }
    }
}
