namespace Six.Ceylon.Ast
{
    public class Extends : AstNode
    {
        public Extends(Instantiation instantiation)
        {
            Instantiation = instantiation;
        }

        public Instantiation Instantiation { get; }
    }
}
