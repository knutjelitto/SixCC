namespace SixBot.Ast
{
    internal class Literal : Terminal
    {
        public Literal(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
