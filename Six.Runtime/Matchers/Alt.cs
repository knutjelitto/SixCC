namespace Six.Runtime.Matchers
{
    public record Alt(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            foreach (var matcher in Matchers)
            {
                matcher.Match(new Context(context.Start,
                    success =>
                    {
                        context.Success(success);
                    }));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
