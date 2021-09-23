namespace SixCC.CC.Tree
{
    internal class Reference : Leaf, Expression
    {
        public Reference(Token token)
            : base(token)
        {
        }
    }
}
