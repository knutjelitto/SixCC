namespace Six.Ceylon.Ast
{
    public sealed class EntryPattern : Node, Pattern, ConditionForCase
    {
        public EntryPattern(Pattern key, Pattern item)
        {
            Key = key;
            Item = item;
        }

        public Pattern Key { get; }
        public Pattern Item { get; }
    }
}
