namespace Six.Ceylon.Ast
{
    public class Alias : Declaration
    {
        public Alias(Identifier name)
            : base(name)
        {
        }

        public override string ItemKind => "d-alias";
    }
}
