namespace Six.Runtime.Matchers
{
    public sealed class Character : Token
    {
        public Character(ImplementationCore core, int id, string name, int codepoint)
            : base(core, id, name)
        {
            Codepoint = codepoint;
        }

        public int Codepoint { get; }

        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.At == Codepoint)
            {
                context.Success(context.Core.Advance(1));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
