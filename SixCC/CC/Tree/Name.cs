namespace SixCC.CC.Tree
{
    internal class Name : Leaf, Expression
    {
        public Name(Token token)
            : base(token)
        {
        }
    }
}
