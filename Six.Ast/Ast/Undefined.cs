namespace Six.Ast
{
    public class Undefined : Expression
    {
        public static readonly Undefined Instance = new Undefined();

        private Undefined() { }

        public override bool IsAtomic => true;

        public override string ToName() => $"-<undefined>-";
    }
}
