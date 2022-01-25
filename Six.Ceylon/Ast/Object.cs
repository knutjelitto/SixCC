namespace Six.Ceylon.Ast
{
    public class Object : Declaration
    {
        public Object(Identifier name)
            : base(name)
        {
        }

        public override string Kind => "object";
    }
}
