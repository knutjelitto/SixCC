namespace SixBot.Ast
{
    internal class Undefined : Expression
    {
        public static readonly Undefined Instance = new Undefined();

        private Undefined() { }
    }
}
