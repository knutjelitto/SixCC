using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class PatternsWithValue : NodeList<PatternWithValue>
    {
        public PatternsWithValue(IEnumerable<PatternWithValue> items) : base(items)
        {
        }
    }

    public sealed class PatternWithValue : Node
    {
        public PatternWithValue(Pattern pattern, ValueSpecifier value)
        {
            Pattern = pattern;
            Value = value;
        }

        public Pattern Pattern { get; }
        public ValueSpecifier Value { get; }
    }
}
