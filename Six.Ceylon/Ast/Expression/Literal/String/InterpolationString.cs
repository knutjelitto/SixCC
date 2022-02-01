using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public abstract class InterpolationString : String
    {
        public InterpolationString(RToken token, string start, string end)
            : base(GetText(token, start, end))
        {
            Start = start;
            End = end;
        }

        public string Start { get; }
        public string End { get; }

        private static string GetText(RToken token, string start, string end)
        {
            Assert(token.Text.StartsWith(start) && token.Text.EndsWith(end));

            return Decode(token.Text[start.Length..^end.Length]);
        }
    }

    public sealed class StartInterpolationString : InterpolationString
    {
        public StartInterpolationString(RToken token) : base(token, "\"", "``") { }
    }

    public sealed class MidInterpolationString : InterpolationString
    {
        public MidInterpolationString(RToken token) : base(token, "``", "``") { }
    }

    public sealed class EndInterpolationString : InterpolationString
    {
        public EndInterpolationString(RToken token) : base(token, "``", "\"") { }
    }
}
