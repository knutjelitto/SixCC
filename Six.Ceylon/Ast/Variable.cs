namespace Six.Ceylon.Ast
{
    public sealed class Variable : Node, Pattern
    {
        public Variable(Type? prefix, Name memberName)
        {
            Prefix = prefix;
            MemberName = memberName;
        }

        public Type? Prefix { get; }
        public Name MemberName { get; }
    }
}
