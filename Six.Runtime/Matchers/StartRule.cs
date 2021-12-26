namespace Six.Runtime.Matchers
{
    public sealed record StartRule(ImplementationCore Core, int Id, string Name)
            : Rule(Core, Id, Name)
    {
        public Cursor? Eof { get; private set; }

        public override void MatchCore(Context context)
        {
            var matcher = this[0];

            matcher.Match(context.Start,
                success =>
                {
                    var eof = Core.__MatchWhite(success);
                    if (eof.At == -1)
                    {
                        Eof = success;

                        context.Success(eof);
                    }
                });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
