namespace Six.Ceylon.Ast
{
    public class CaseTypes : AstNode
    {
        public CaseTypes(TypeList types)
        {
            Types = types;
        }

        public TypeList Types { get; }
    }
}
