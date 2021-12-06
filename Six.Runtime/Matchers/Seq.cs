namespace Six.Runtime.Matchers
{
    public record Seq(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
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

                    matcher.Match(new Context(next,
                        succ =>
                        {
                            match(index + 1, succ);
                        }));
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
