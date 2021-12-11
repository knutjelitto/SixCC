namespace Six.Runtime.Matchers
{
    public sealed record Optional(ImplementationCore Core, int Id, string Name) : Structural(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            context.Success(context.Start);

            Matchers[0].Match(
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
