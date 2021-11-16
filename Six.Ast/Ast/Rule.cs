using System.Collections.Generic;

namespace Six.Ast
{
    public sealed class Rule : Expression
    {
        private readonly List<Reference> references = new List<Reference>();

        public Rule(string name, Expression expression)
        {
            Kind = RuleKind.Undefined;
            Name = name;
            Expression = expression;
        }

        public RuleKind Kind { get; set; }
        public int Order { get; set; }
        public string Name { get; }
        public Expression Expression { get; set; }
        public IReadOnlyList<Reference> References => references;
        public override bool IsAtomic => Expression.IsAtomic;
        public override bool IsCompact => Expression.IsCompact;
        public override string ToName() => $"{Name}";

        public override bool Equals(object? obj) => obj is Rule other && Name == other.Name;
        public override int GetHashCode() => Name.GetHashCode();

        public Reference Add(Reference reference)
        {
            references.Add(reference);
            return reference;
        }
    }
}
