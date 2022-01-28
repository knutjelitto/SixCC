namespace Six.Ceylon.Ast
{
    public class Annotation
    {
        public Annotation(Identifier name, ArgumentList? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public ArgumentList? Arguments { get; }
    }
}
