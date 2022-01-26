namespace Six.Ceylon.Ast
{
    public class Class : Declaration
    {
        public Class(Identifier name)
            : base(name)
        {
        }

        public override string ItemKind => "d-class";
    }
}
