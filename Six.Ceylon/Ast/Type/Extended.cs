namespace Six.Ceylon.Ast
{
    public class Extended : AstNode
    {
        public Extended(Instantiation instantiation)
        {
            Instantiation = instantiation;
        }

        public Instantiation Instantiation { get; }
    }
}
