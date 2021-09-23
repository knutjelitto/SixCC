namespace Six.Ceylon.Ast
{
    public sealed class EntryType : Node, SugarType
    {
        public EntryType(Type key, Type item)
        {
            Key = key;
            Item = item;
        }

        public Type Key { get; }
        public Type Item { get; }
    }
}
