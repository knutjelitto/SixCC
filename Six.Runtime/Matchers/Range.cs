namespace Six.Runtime.Matchers
{
    public sealed class Range : Token
    {
        public Range(ImplementationCore core, int id, string name, int cp1, int cp2)
            : base(core, id, name)
        {
            CP1 = cp1;
            CP2 = cp2;
        }

        public int CP1 { get; }
        public int CP2 { get; }

        public override void MatchCore(Context context)
        {
            var at = context.Start.At;

            if (CP1 <= at && at <= CP2)
            {
                context.Success(context.Start.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
