namespace Six.Ceylon.Ast
{
    public sealed class SequenceType : Node, SugarType
    {
        public SequenceType(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
