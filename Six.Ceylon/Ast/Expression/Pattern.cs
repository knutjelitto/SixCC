namespace Six.Ceylon.Ast
{
    public interface Pattern : Parameter, Expr
    {
        new public abstract record List(IEnumerable<Pattern> Items) : ReadOnlyList<Pattern>(Items);

        new public sealed record Tuple(Patterns patterns) : Pattern;
        public sealed record Entry(Pattern Key, Pattern Value) : Pattern;
        public sealed record Variadic(Type? Type, string Op, Identifier Name) : Pattern;
        public sealed record Variable(Type? Type, Identifier Name, ParametersList Parameters) : Pattern;
        public sealed record LetVariable(Pattern Pattern, Expr.Specifier Specifier) : Pattern;
    }

    public sealed record Patterns(IEnumerable<Pattern> Items) : Pattern.List(Items);
}
