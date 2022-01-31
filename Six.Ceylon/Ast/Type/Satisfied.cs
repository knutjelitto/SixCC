namespace Six.Ceylon.Ast
{
    public class Satisfied : AstNode
    {
        public Satisfied(TypeList types)
        {
            Types = types;
        }

        public TypeList Types { get; }
    }
}
