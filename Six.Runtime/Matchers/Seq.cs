namespace Six.Runtime.Matchers
{
    public sealed record Seq(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            match(0, context.Start);

            void match(int index, Cursor next)
            {
                if (index == Matchers.Length)
                {
                    context.Success(next);
                }
                else
                {
                    var matcher = Matchers[index];

                    matcher.Match(
                        next,
                        success =>
                        {
                            match(index + 1, success);
                        });
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
