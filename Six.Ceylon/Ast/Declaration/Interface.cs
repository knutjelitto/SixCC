namespace Six.Ceylon.Ast
{
    public class Interface : Declaration
    {
        public Interface(Identifier name)
            : base(name)
        {
        }

        public override string ItemKind => "d-interface";
    }
}
