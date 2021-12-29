namespace Six.Runtime.Matchers
{
    public sealed class Any : Token
    {
        public Any(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            if (context.Start.At != -1)
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
