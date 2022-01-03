namespace Six.Runtime.Matchers
{
    public class Eof : Token
    {
        public Eof(ImplementationCore core, int id, string name) : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            context.Core = Core.__MatchWhite(context.Start);

            if (context.Core.At == -1)
            {
                context.Success(context.Core);
            }
        }
    }
}
