namespace Six.Runtime.Matchers
{
    public sealed class Optional : Structural
    {
        public Optional(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            var matcher = this[0];

            context.Success(context.Start);

            matcher.Match(
                context.Start,
                success =>
                {
                    // bail out nullables
                    if (success > context.Start)
                    {
                        context.Success(success);
                    }
                });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
