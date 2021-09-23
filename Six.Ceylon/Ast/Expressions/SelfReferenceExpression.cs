namespace Six.Ceylon.Ast
{
    public sealed class SelfReferenceExpression : Node, Expression
    {
        public SelfReferenceExpression(Terminal selfReference)
        {
            SelfReference = selfReference;
        }

        public Terminal SelfReference { get; }
    }
}
