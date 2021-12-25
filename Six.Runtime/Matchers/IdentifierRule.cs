namespace Six.Runtime.Matchers
{
    public sealed record IdentifierRule(ImplementationCore Core, int Id, string Name) : DfaRule(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
#if true
            // TODO
#else
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.Match(Text))
            {
                context.Success(context.Core.Advance(Text.Length));
            }
#endif
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
