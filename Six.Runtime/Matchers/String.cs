namespace Six.Runtime.Matchers
{
    public sealed class String : Token
    {
        public String(ImplementationCore core, int id, string name, string text)
            : base(core, id, name)
        {
            Text = text;
        }

        public string Text { get; }

        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.Match(Text))
            {
                context.Success(context.Core.Advance(Text.Length));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
