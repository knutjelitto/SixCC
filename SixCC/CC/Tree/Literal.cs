namespace SixCC.CC.Tree
{
    internal class Literal : Leaf, Expression
    {
        public Literal(Token token)
            : base(token)
        {
        }
    }
}
