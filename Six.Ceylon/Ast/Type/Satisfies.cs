namespace Six.Ceylon.Ast
{
    public class Satisfies : AstNode
    {
        public Satisfies(TypeList types)
        {
            Types = types;
        }

        public TypeList Types { get; }
    }
}
