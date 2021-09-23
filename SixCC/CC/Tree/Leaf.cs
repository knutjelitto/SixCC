using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal abstract class Leaf : Node
    {
        public Leaf(Token token)
        {
            Token = token;
        }

        public Token Token { get; }
        public ILocation Location => Token.Location;
        public string Text => Token.Text;
        public string Head => Token.Text;
    }
}
