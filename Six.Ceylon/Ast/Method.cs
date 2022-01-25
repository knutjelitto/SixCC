namespace Six.Ceylon.Ast
{
    public class Method : Declaration
    {
        public Method(Identifier name)
            : base(name)
        {
        }

        public override string Kind => "method";
    }
}
