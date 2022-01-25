namespace Six.Ceylon.Ast
{
    public class Attribute : Declaration
    {
        public Attribute(Identifier name)
            : base(name)
        {
        }

        public override string Kind => "attribute";
    }
}
