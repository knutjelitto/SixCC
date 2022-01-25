namespace Six.Ceylon.Ast
{
    public class Class : ClassOrInterface
    {
        public Class(Identifier name)
            : base(name)
        {
        }

        public override string Kind => "class";
    }
}
