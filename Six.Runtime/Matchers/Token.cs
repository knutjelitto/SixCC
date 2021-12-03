namespace Six.Runtime.Matchers
{
    public record Token(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
#if false
        public override void Match(Context context)
        {
            if (!Core.__InToken)
            {
                Core.__InToken = true;
                Core.__CollectWhitespace(new Context(context.Start,
                    succ => Continue(succ),
                    fail => Continue(fail)));
                Core.__InToken = false;

                void Continue(Cursor cursor)
                {
                    MatchCore(new Context(cursor,
                        succ =>
                        {
                            Core.__InToken = false;
                            context.Success(succ);
                            Core.__InToken = true;
                        },
                        fail =>
                        {
                            Core.__InToken = false;
                            context.Failure(fail);
                            Core.__InToken = true;
                        }));
                }

            }
            else
            {
                MatchCore(context);
            }
        }
#endif

        protected override void MatchCore(Context context)
        {
            Matchers[0].Match(context);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
