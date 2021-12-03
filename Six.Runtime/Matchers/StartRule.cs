namespace Six.Runtime.Matchers
{
    public record StartRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Matchers[0].Match(new Context(context.Start,
                success =>
                {
                    Core.__CollectWhitespace(new Context(success,
                        innerSuccess =>
                        {
                            if (innerSuccess.At == -1)
                            {
                                context.Success(innerSuccess);
                            }
                            else
                            {
                                context.Failure(innerSuccess);
                            }
                        },
                        innerFailure =>
                        {
                            // never ever
                            Assert(false);
                        }));
                },
                failure =>
                {
                    context.Failure(failure);
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
