using Six.Runtime.Matchers;

namespace Six.Runtime
{
    public sealed class Context
    {
        public readonly List<Action<Cursor>> Continues = new();
        public readonly CursorSet Nexts;
        public readonly Matcher Matcher;
        public readonly Cursor Start;
        public Cursor Core;


        [DebuggerStepThrough]
        private Context(Matcher matcher, Cursor start)
        {
            Matcher = matcher;
            Core = Start = start;
            Nexts = new CursorSet();
        }

        public static void Match(Matcher matcher, Cursor start, Action<Cursor> onMatched)
        {
            if (!matcher.Contexts.TryGetValue(start, out var context))
            {
                context = new Context(matcher, start);
                matcher.Contexts.Add(start, context);
                context.Continues.Add(onMatched);

                matcher.MatchCore(context);
            }
            else
            {
                context.Continues.Add(onMatched);
                foreach (var next in context.Nexts)
                {
                    onMatched(next);
                }
            }
        }

        public void Success(Cursor next)
        {
            if (Nexts.Add(next))
            {
                var count = Continues.Count;
                for (var i = 0; i < count; i++)
                {
                    Continues[i](next);
                }
            }
        }

        public override string ToString()
        {
            return $"context({Start}, [{Nexts}], [#{Continues.Count}], {Matcher})";
        }
    }
}
