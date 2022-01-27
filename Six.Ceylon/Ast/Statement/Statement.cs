namespace Six.Ceylon.Ast
{
    public class Statement
    {
        public virtual string ItemKind => GetType().Name.ToLowerInvariant();
    }
}
