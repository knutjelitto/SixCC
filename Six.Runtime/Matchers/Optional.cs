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
            this[0].Match(
                context.Start,
                success =>
                {
                    // bail out nullables
                    if (success > context.Start)
                    {
                        context.Success(success);
                    }
                });

            context.Success(context.Start);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
