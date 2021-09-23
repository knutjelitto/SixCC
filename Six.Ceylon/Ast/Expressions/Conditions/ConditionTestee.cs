namespace Six.Ceylon.Ast
{
    public abstract class ConditionTestee : Node
    {
    }

    public sealed class NameTestee : ConditionTestee
    {
        public NameTestee(Name name)
        {
            Name = name;
        }

        public Name Name { get; }
    }

    public sealed class PatternTestee : ConditionTestee
    {
        public PatternTestee(PatternWithValue patternWithValue)
        {
            PatternWithValue = patternWithValue;
        }

        public PatternWithValue PatternWithValue { get; }
    }
}
