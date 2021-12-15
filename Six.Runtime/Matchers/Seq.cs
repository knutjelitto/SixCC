namespace Six.Runtime.Matchers
{
    public sealed record Seq(ImplementationCore Core, int Id, string Name) : Structural(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            match(0, context.Start);

            void match(int index, Cursor next)
            {
                if (index == Count)
                {
                    context.Success(next);
                }
                else
                {
                    var matcher = this[index];

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
