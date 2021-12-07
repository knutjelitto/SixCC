using Six.Runtime.Matchers;

namespace Six.Runtime
{
    public sealed class Context
    {
        private readonly Action<Cursor> Continue;
        public readonly Matcher Matcher;
        public readonly Cursor Start;
        public readonly HashSet<int> Nexts;


        [DebuggerStepThrough]
        private Context(Matcher matcher, Cursor start, Action<Cursor> next)
        {
            Matcher = matcher;
            Start = start;
            Continue = next;
            Nexts = new HashSet<int>();
        }

        public static Context From(Matcher matcher, Cursor start, Action<Cursor> next)
        {
            return new Context(matcher, start, next);
        }

        public void Success(Cursor next)
        {
            Nexts.Add(next.Offset);
            Continue(next);
        }

        public override string ToString()
        {
            var nexts = string.Join(',', Nexts.OrderBy(x => x));

            return $"context({Start}, {Matcher}, [{nexts}])";
        }
    }
}
