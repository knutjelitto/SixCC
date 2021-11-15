namespace SixBot.Ast
{
    internal class Epsilon : Base
    {
        public static readonly Epsilon Instance = new Epsilon();

        private Epsilon() { }

        public override string ToName() => "ε";
    }
}
