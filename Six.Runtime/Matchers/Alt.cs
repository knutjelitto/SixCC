namespace Six.Runtime.Matchers
{
    public record Alt(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            var succeeded = false;

            foreach (var matcher in Matchers)
            {
                matcher.Match(new Context(context.Start,
                    success =>
                    {
                        succeeded = true;
                        context.Success(success);
                    },
                    failure =>
                    {
                        // ignore, Alt fails as a whole
                    }));
            }

            if (!succeeded)
            {
                context.Failure(context.Start);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
