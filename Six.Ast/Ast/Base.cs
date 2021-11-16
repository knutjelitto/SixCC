namespace Six.Ast
{
    public abstract class Base : Expression
    {
        public override bool IsAtomic => true;
    }
}
