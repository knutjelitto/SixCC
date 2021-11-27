namespace Six.Ast
{
    public class Reference : ReferenceCore
    {
        internal Reference(Grammar grammar, ILocation location, string name)
            : base(grammar, location, name)
        {
        }

        public Symbol Symbol => Grammar[Name];

        public override bool IsSimple => true;
        public override bool IsCompact => false;
    }
}
