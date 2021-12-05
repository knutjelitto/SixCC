namespace Six.Ast
{
    public class Reference : ReferenceCore
    {
        internal Reference(AstGrammar grammar, ILocation location, string name)
            : base(grammar, location, name)
        {
        }

        public override bool IsSimple => true;
    }
}
