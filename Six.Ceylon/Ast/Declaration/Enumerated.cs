namespace Six.Ceylon.Ast
{
    public class Enumerated : Declaration
    {
        public Enumerated(Identifier name)
            : base(name)
        {
        }

        public override string ItemKind => "d-enumerated";
    }
}
