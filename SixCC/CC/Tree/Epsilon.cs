namespace SixCC.CC.Tree
{
    internal class Epsilon : Leaf, Expression
    {
        public Epsilon(Token token)
            : base(token)
        {
        }
    }
}
