namespace Six.Ceylon.Ast
{
    public class Annotation
    {
        public Annotation(Identifier name, Arguments? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public Arguments? Arguments { get; }
    }
}
