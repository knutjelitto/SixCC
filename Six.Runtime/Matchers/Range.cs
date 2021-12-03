namespace Six.Runtime.Matchers
{
    public record Range(ImplementationCore Core, int Id, string Name, int CP1, int CP2) : Token(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            var at = context.Start.At;

            if (CP1 <= at && at <= CP2)
            {
                context.Success(context.Start.Advance(1));
            }
            else
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
