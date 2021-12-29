namespace Six.Runtime.Matchers
{
    public sealed class Not : Structural
    {
        public Not(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            var matcher = this[0];
            var fail = false;

            matcher.Match(
                context.Start,
                success =>
                {
                    fail = true;
                });

            if (!fail)
            {
                context.Success(context.Start);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
