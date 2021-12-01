namespace Six.Runtime.Matchers
{
    public record StartRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continueWith)
        {
            Matchers[0].Match(current, new Continuation(current,
                success =>
                {
                    Core.__CollectWhitespace(success, new Continuation(success,
                        innerSuccess =>
                        {
                            if (innerSuccess.At == -1)
                            {
                                continueWith.Success(innerSuccess);
                            }
                            else
                            {
                                continueWith.Fail(innerSuccess);
                            }
                        },
                        innerFailure =>
                        {
                            continueWith.Fail(innerFailure);
                        }));
                },
                failure =>
                {
                    continueWith.Fail(failure);
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
