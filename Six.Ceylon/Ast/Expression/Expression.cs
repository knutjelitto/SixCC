namespace Six.Ceylon.Ast
{
    public record Expression : IExpression
    {
        public record Infix(string Op, IExpression Left, IExpression Right) : Expression;
        public record Infix2(IExpression Left, string Op1, IExpression Mid, string Op2, IExpression Right) : Expression;
        public record Prefix(string Op, IExpression Right) : Expression;
        public record Postfix(IExpression Left, string Op) : Expression;
        public record Specifier(string Op, IExpression Right) : Prefix(Op, Right);
        public record ValueSpecifier(string Op, IExpression Right) : Specifier(Op, Right);
        public record FunctionSpecifier(string Op, IExpression Right) : Specifier(Op, Right);
        public record SelfReference(string Reference) : Expression;
        public record Indexed(IExpression Expr, IExpression Index) : Expression;
        public record SpanIndex(IExpression From, IExpression To) : Expression;
        public record MeasureIndex(IExpression From, IExpression Count) : Expression;
        public record FromIndex(IExpression From) : Expression;
        public record ToIndex(IExpression To) : Expression;
        public record Interpolation(IReadOnlyList<InterpolationString> Strings, IReadOnlyList<IExpression> Expressions) : Expression;
        public sealed record Call(IExpression Expr, Arguments Arguments) : Expression;
    }
}
