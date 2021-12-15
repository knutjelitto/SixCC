namespace Six.Runtime.Matchers
{
    public sealed record PlainRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            if (Name == "element")
            {
                Assert(true);
            }


            this[0].Match(context.Start,
                success =>
                {
                    context.Success(success);
                });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
