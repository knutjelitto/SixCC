namespace Six.Ceylon.Ast
{
    public class Interface : ClassOrInterface
    {
        public Interface(Identifier name)
            : base(name)
        {
        }

        public override string Kind => "interface";
    }
}
