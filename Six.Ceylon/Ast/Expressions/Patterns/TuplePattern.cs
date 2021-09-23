using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TuplePattern : Node, Pattern, ConditionForCase
    {
        public TuplePattern(IEnumerable<Pattern> patterns, VariadicVariable? variadic)
        {
            Patterns = new Patterns(patterns);
            Variadic = variadic;
        }

        public Patterns Patterns { get; }
        public VariadicVariable? Variadic { get; }
    }

    public sealed class VariadicVariable : Node, Pattern
    {
        public VariadicVariable(Type? type, Name memberName)
        {
            Type = type;
            MemberName = memberName;
        }

        public Type? Type { get; }
        public Name MemberName { get; }
    }
}
