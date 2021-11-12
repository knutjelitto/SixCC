namespace SixBot.Ast
{
    internal class Literal : Expression
    {
        public Literal(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
