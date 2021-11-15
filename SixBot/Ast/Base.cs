namespace SixBot.Ast
{
    internal abstract class Base : Expression
    {
        public override bool IsAtomic => true;
    }
}
