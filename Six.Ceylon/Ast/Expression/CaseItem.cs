namespace Six.Ceylon.Ast
{
    public interface CaseItem : AstNode
    {
        public sealed record IsCase(Type Type) : CaseItem;
    }
}
