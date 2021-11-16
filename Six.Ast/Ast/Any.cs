namespace Six.Ast
{
    public class Any : Expression
    {
        public static readonly Any Instance = new Any();

        private Any() { }

        public override bool IsAtomic => true;

        public override string ToName() => ".";
    }
}
