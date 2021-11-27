namespace Six.Ast
{
    public class ReferenceCore : Expression
    {
        internal ReferenceCore(Grammar grammar, ILocation location, string name)
            : base(location)
        {
            Grammar = grammar;
            Name = name;
        }

        public Grammar Grammar { get; }
        public string Name { get; }

        public override bool IsSimple => true;
        public override bool IsCompact => false;
    }
}
