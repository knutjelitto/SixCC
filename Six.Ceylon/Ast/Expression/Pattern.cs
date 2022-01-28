namespace Six.Ceylon.Ast
{
    public interface Pattern : Parameter
    {
        public record Instance : Pattern;

        public sealed record Tuple(PatternList patterns) : Pattern;
    }
}
