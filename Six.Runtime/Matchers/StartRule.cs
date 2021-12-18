namespace Six.Runtime.Matchers
{
    public sealed record StartRule(ImplementationCore Core, int Id, string Name) : Rule(Core, Id, Name)
    {
        public Cursor? White { get; private set; }

        public override void MatchCore(Context context)
        {
            this[0].Match(context.Start,
                success =>
                {
                    var white = Core.__MatchWhite(success);
                    if (white.At == -1)
                    {
                        White = success;

                        context.Success(white);
                    }
                });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
