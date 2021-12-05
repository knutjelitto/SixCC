namespace Six.Ast
{
    public class ReferenceCore : Expression
    {
        internal ReferenceCore(AstGrammar grammar, ILocation location, string name)
            : base(location)
        {
            Grammar = grammar;
            Name = name;
        }

        public AstGrammar Grammar { get; }
        public string Name { get; }

        public override bool IsSimple => true;
    }
}
