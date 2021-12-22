namespace Six.Runtime.Matchers
{
    public sealed record Optional(ImplementationCore Core, int Id, string Name) : Structural(Core, Id, Name)
    {
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
