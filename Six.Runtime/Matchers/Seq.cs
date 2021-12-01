namespace Six.Runtime.Matchers
{
    public record Seq(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor cursor, Continuation continuation)
        {
            match(0, cursor);

            void match(int index, Cursor next)
            {
                if (index == Matchers.Length)
                {
                    continuation.Success(next);
                }
                else
                {
                    var matcher = Matchers[index];

                    matcher.Match(next, new Continuation(next,
                        succ =>
                        {
                            match(index + 1, succ);
                        },
                        fail =>
                        {
                            continuation.Fail(fail);
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
